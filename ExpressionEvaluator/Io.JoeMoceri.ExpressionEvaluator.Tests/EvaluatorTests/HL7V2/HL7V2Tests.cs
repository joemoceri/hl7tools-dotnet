using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
    [TestClass]
    public class HL7V2Tests
    {
		private void CompareFileWithMessage(string path, HL7V2Message message)
        {
			var lines = File.ReadAllLines(path);

			var messageToString = message.ToString();

			var joinedMessageFile = string.Join(Environment.NewLine, lines.Where(l => !char.IsControl(l[0]) && l.Length > 1)).Trim();

            Assert.AreEqual(messageToString, joinedMessageFile);

			for (var i = 0; i < lines.Length; i++)
			{
                if (char.IsControl(lines[i][0]) && lines[i].Length == 1)
                {
					continue;
                }

				var segment = message.MessageSegments[i];

				// the lines should be the same as the message segment
				Assert.AreEqual(lines[i], segment.ToString());

				// segment names are the first 3 characters
				var segmentName = lines[i].Substring(0, 3);

				// check the segment name
				Assert.AreEqual(segmentName, message.MessageSegments[i].SegmentName);

				// remove the segment name from the rest
				lines[i] = lines[i].Remove(0, 4);

				// Compare this to the message Values, they should be the same and order should be respected
				var fields = lines[i].Split(HL7V2ExpressionConfiguration.fieldDelimiter).ToList();

				if (HL7V2ExpressionConfiguration.specialSegmentHeaders.Any(a => a.Equals(segmentName)))
				{
					fields.Insert(0, HL7V2ExpressionConfiguration.fieldDelimiter);
				}

				// check field values
				for (var j = 0; j < fields.Count; j++)
				{
					var field = segment[j + 1];

					// check the field ids
					Assert.AreEqual(j + 1, field.Id);

					Assert.AreEqual(field.Delimiter, HL7V2ExpressionConfiguration.fieldDelimiter);

					Assert.AreEqual(fields[j], field.Value);

					if (HL7V2ExpressionConfiguration.specialSegmentHeaders.Any(a => a.Equals(segmentName)) && j <= 1)
                    {
						continue;
                    }

					// check field repetitions
					var fieldRepetitions = fields[j].Split(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

					for (var a = 0; a < fieldRepetitions.Length; a++)
                    {
						var fieldRepetition = field.GetFieldRepetition(a + 1);

                        Assert.AreEqual(a + 1, fieldRepetition.Id);

						Assert.AreEqual(fieldRepetition.Delimiter, HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

						Assert.AreEqual(fieldRepetitions[a], fieldRepetition.Value);

						var components = fieldRepetitions[a].Split(HL7V2ExpressionConfiguration.componentDelimiter);

						// check components
						if (components.Length > 1)
                        {
							for (var b = 0; b < components.Length; b++)
							{
								var component = field[b + 1, a + 1];

								Assert.AreEqual(b + 1, component.Id);

								Assert.AreEqual(component.Delimiter, HL7V2ExpressionConfiguration.componentDelimiter);

								Assert.AreEqual(components[b], component.Value);

								var subComponents = components[b].Split(HL7V2ExpressionConfiguration.subComponentDelimiter);

								// check sub components
								if (subComponents.Length > 1)
                                {
									for (var c = 0; c < subComponents.Length; c++)
                                    {
										var subComponent = component[c + 1];

										Assert.AreEqual(c + 1, subComponent.Id);

										Assert.AreEqual(subComponent.Delimiter, HL7V2ExpressionConfiguration.subComponentDelimiter);

										Assert.AreEqual(subComponents[c], subComponent.Value);
                                    }
                                }
							}
                        }
                    }
				}
			}
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages")]
		public void HL7V2Tests_EvaluateHL7V2File_CompareFileWithMessage()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var paths = Directory.GetFiles("EvaluatorTests/HL7V2/sample-messages");

			for (var i = 0; i < paths.Length; i++)
            {
				var message = evaluator.EvaluateHL7V2File(paths[i]);
				CompareFileWithMessage(paths[i], message);

				Assert.IsNull(message.Error);
            }
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A05 Pre-admit Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_Message()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var msh = message["MSH"];

			// Assert
			Assert.AreEqual(message.Error, null);

			Assert.AreEqual(message.MessageSegments.Count > 0, true);

			Assert.AreEqual(message.Segments("MSH").Count, 1);

			Assert.AreEqual(msh.SegmentName, "MSH");

			Assert.AreEqual(message["MSH"].SegmentName, "MSH");

			Assert.AreEqual(message["MSH"].SegmentName, msh.SegmentName);

			Assert.AreEqual(message["MSH", 0].SegmentName, "MSH");

			// Get
			Assert.AreEqual(message.Get("MSH.1").Value, message["MSH"][1].Value);

			Assert.AreEqual(message.Get("PID.5.1").Value, message["PID"][5][1].Value);

			Assert.AreEqual(message.Get("PID(1).5.1").Value, message["PID"][5][1].Value);

			Assert.AreEqual(message.Get("GT1.6(2).1").Value, message["GT1"][6][1, 2].Value);

			message = evaluator.EvaluateHL7V2File("ADT-A05 Pre-admit Patient.txt");

			Assert.AreEqual(message.Error, null);

			Assert.AreEqual(message.Get("PD1.4.9.2").Value, message["PD1"][4][9][2].Value);

			var previousCount = message.MessageSegments.Count;

			// Add message segment
			var obr = message.AddMessageSegment("OBR");

			var lastSegment = message.MessageSegments.Last();

			Assert.AreEqual(obr.Fields.Count, 0);

			Assert.AreEqual(obr.SegmentName, "OBR");

			Assert.AreEqual(previousCount + 1, message.MessageSegments.Count);

			Assert.AreEqual(message["OBR"].SegmentName, obr.SegmentName);

			Assert.AreEqual(message["OBR", 0].SegmentName, obr.SegmentName);

			Assert.AreEqual(lastSegment.SegmentName, obr.SegmentName);

			// Remove message segment
			var removed = message.RemoveMessageSegment("OBR");

			Assert.AreEqual(removed, true);

			// Insert message segment
			var frontObr = message.InsertMessageSegment("OBR");

			Assert.AreEqual(previousCount + 1, message.MessageSegments.Count);

			Assert.AreEqual(message.MessageSegments.First().SegmentName, frontObr.SegmentName);

			Assert.AreEqual(message.MessageSegments.First().SegmentName, "OBR");

			removed = message.RemoveMessageSegment("OBR");

			Assert.AreEqual(removed, true);

			// Insert message segment at index
			var index = message.MessageSegments.Count / 2;

			obr = message.InsertMessageSegment("OBR", index);

			var obrByIndex = message.MessageSegments[index];

			Assert.AreEqual(obr.SegmentName, obrByIndex.SegmentName);

			Assert.AreEqual(previousCount + 1, message.MessageSegments.Count);

			Assert.AreEqual(obrByIndex.SegmentName, "OBR");

			removed = message.RemoveMessageSegment("OBR");

			Assert.AreEqual(removed, true);

			// Remove message segment at index
			Assert.AreEqual(message.MessageSegments.First().SegmentName, "MSH");

			message.AddMessageSegment("OBR");

			var obrtest = message.AddMessageSegment("OBR");

			obrtest.AddField("test_value");

			Assert.AreEqual(obrtest.Fields.Count == 1, true);

			message.AddMessageSegment("OBR");

			removed = message.RemoveMessageSegment("OBR", 1);

			Assert.AreEqual(removed, true);

			Assert.AreEqual(message["OBR", 1].Fields.Count, 0);

			// ToHL7V2MessageFile
			var messageToFile = message.ToHL7V2MessageFile();

			for (var i = 0; i < messageToFile.Count; i++)
            {
				Assert.AreEqual(messageToFile[i], message.MessageSegments[i].ToString());
            }

			// to string
			var lines = File.ReadAllLines("ADT-A05 Pre-admit Patient.txt");

			var messageToString = message.ToString();

			var joinedMessageFile = string.Join(Environment.NewLine, lines.Where(l => !char.IsControl(l[0]) && l.Length > 1)).Trim();

			Assert.AreEqual(messageToString, joinedMessageFile);

			var msh9 = ((HL7V2Field)message.Get("MSH.9"));

			// rebuild
			msh9.AddComponent("_test");

			// check they're equal before
			Assert.AreEqual(message.ToString(), joinedMessageFile);

			message.Rebuild();

			// after they should be different, the value of msh 9 is different because of the new component
			Assert.AreNotEqual(message.ToString(), joinedMessageFile);

			// remove the component, it's the last one
			removed = msh9.RemoveComponent(msh9.Components().Count);

			// make sure it's removed
			Assert.AreEqual(removed, true);

			// when rebuilding, it should be the same now, as it was
			message.Rebuild();

			messageToString = message.ToString();

			Assert.AreEqual(messageToString, joinedMessageFile);

			// check rebuild for field repetition
			var fieldRepetition = msh9.AddFieldRepetition("_test");

			Assert.AreEqual(fieldRepetition.Value, "_test");

			message.Rebuild();

			messageToString = message.ToString();

			Assert.AreNotEqual(messageToString, joinedMessageFile);

			removed = msh9.RemoveFieldRepetition(msh9.FieldRepetitions.Count);

			Assert.AreEqual(removed, true);

			message.Rebuild();

			messageToString = message.ToString();

			Assert.AreEqual(messageToString, joinedMessageFile);

			// check rebuild for sub component
			var component = (HL7V2Component)message.Get("PD1.4.9");

			var subComponent = component.AddSubComponent("_test");

			Assert.AreEqual(subComponent.Value, "_test");

			message.Rebuild();

			messageToString = message.ToString();

			Assert.AreNotEqual(messageToString, joinedMessageFile);

			removed = component.RemoveSubComponent(component.SubComponents.Count);

			Assert.AreEqual(removed, true);

			message.Rebuild();

			messageToString = message.ToString();

			Assert.AreEqual(messageToString, joinedMessageFile);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_Message_MessageSegment()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var msh = message["MSH"];

			var value = $"{Guid.NewGuid()}";

			Assert.AreNotEqual(msh[2].Value, value);

			msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_Message_MessageSegment_Field()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var msh = message["MSH"];

			// Update Field
			var value = $"{Guid.NewGuid()}";

			Assert.AreNotEqual(msh[2].Value, value);

			var updateField = msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

			Assert.AreEqual(updateField.Value, value);

			// Add Field
			value = $"{Guid.NewGuid()}";

			var previousCount = msh.Fields.Count;

			var field = msh.AddField(value);

			// new field should be last field
			var lastField = msh.Fields.Last();

			// count should be 1 higher
			Assert.AreEqual(msh.Fields.Count, previousCount + 1);

			Assert.AreEqual(field.Delimiter, HL7V2ExpressionConfiguration.fieldDelimiter);

			Assert.AreEqual(field.Value, value);

			Assert.AreEqual(field.FieldRepetitions.Count, 0);

			// make sure the field and the last field are the same
			Assert.AreEqual(field.Id, lastField.Id);

			Assert.AreEqual(field.Value, lastField.Value);

			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_Message_MessageSegment_Field_FieldRepetition()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var msh = message["MSH"];

			var value = $"{Guid.NewGuid()}";

			Assert.AreNotEqual(msh[2].Value, value);

			var field = msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

			//Assert.AreEqual(field.GetFieldRepetition(1).Value, value);

			//Assert.AreEqual(field.GetFieldRepetition(1).Id, 1);

			//Assert.AreEqual(field.GetFieldRepetition(1).Delimiter, HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

			//Assert.AreEqual(field.GetFieldRepetition(1).Components.Count, 0);



			//var fieldRepetition = field.GetFieldRepetition(1);

			//Assert.AreEqual(fieldRepetition.Id, 1);

			//Assert.AreEqual(field.Value, fieldRepetition.Value);

			//Assert.AreEqual(fieldRepetition.Delimiter, HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

			//Assert.AreEqual(fieldRepetition.Components.Count, 1);

			//fieldRepetition = field.FieldRepetitions[0];

			//Assert.AreEqual(fieldRepetition.Id, 1);

			//Assert.AreEqual(field.Value, fieldRepetition.Value);

			//Assert.AreEqual(fieldRepetition.Components.Count, 1);

			//Assert.AreEqual(fieldRepetition.Delimiter, HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);



			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_Message_MessageSegment_Field_FieldRepetition_Component()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var msh = message["MSH"];

			var value = $"{Guid.NewGuid()}";

			Assert.AreNotEqual(msh[2].Value, value);

			msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

			//var component = fieldRepetition[1];

			//Assert.AreEqual(component.Id, 1);

			//Assert.AreEqual(field.Value, component.Value);

			//Assert.AreEqual(component.SubComponents.Count, 1);

			//Assert.AreEqual(component.Delimiter, HL7V2ExpressionConfiguration.componentDelimiter);

			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_Message_MessageSegment_Field_FieldRepetition_Component_SubComponent()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var msh = message["MSH"];

			var value = $"{Guid.NewGuid()}";

			Assert.AreNotEqual(msh[2].Value, value);

			msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

			//var subComponent = component[1];

			//Assert.AreEqual(subComponent.Id, 1);

			//Assert.AreEqual(field.Value, subComponent.Value);

			//Assert.AreEqual(subComponent.Delimiter, HL7V2ExpressionConfiguration.subComponentDelimiter);

			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		public void HL7V2Tests_HL7V2ExpressionConfiguration()
        {

        }

		[TestMethod]
		public void HL7V2Tests_EvaluateHL7V2File()
        {

        }
	}
}
