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
		public void HL7V2Tests_EvaluateHL7V2File_Message()
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

			// validation
			Assert.AreEqual(message.Get("INVALID"), null);

			Assert.AreEqual(message.Get("...."), null);

			Assert.AreEqual(message.Get("a.ba.c.d"), null);

			Assert.AreEqual(message.Get(".a.ba.c.d"), null);

			Assert.AreEqual(message.Get("a.ba.c.d."), null);

			Assert.AreEqual(message.Get(null), null);

			Assert.AreEqual(message.Get(string.Empty), null);

			// Add message segment
			var previousCount = message.MessageSegments.Count;
			
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

			// validation
			removed = message.RemoveMessageSegment("NOPE");

			Assert.AreEqual(removed, false);

			removed = message.RemoveMessageSegment("MSH", -1);

			Assert.AreEqual(removed, false);

			removed = message.RemoveMessageSegment("MSH", message.MessageSegments.Count);

			Assert.AreEqual(removed, false);

			// Insert message segment
			var frontObr = message.InsertMessageSegment("OBR");

			Assert.AreEqual(previousCount + 1, message.MessageSegments.Count);

			Assert.AreEqual(message.MessageSegments.First().SegmentName, frontObr.SegmentName);

			Assert.AreEqual(message.MessageSegments.First().SegmentName, "OBR");

			// validation
			frontObr = message.InsertMessageSegment("OBR", -1);

			Assert.AreEqual(frontObr, null);

			frontObr = message.InsertMessageSegment("OBR", message.MessageSegments.Count + 1);

			Assert.AreEqual(frontObr, null);

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

			// rebuild
			var msh9 = ((HL7V2Field)message.Get("MSH.9"));

			msh9.AddComponent("_test");

			Assert.AreEqual(message.ToString(), joinedMessageFile);

			message.Rebuild();

			Assert.AreNotEqual(message.ToString(), joinedMessageFile);

			removed = msh9.RemoveComponent(msh9.Components().Count);

			Assert.AreEqual(removed, true);

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
		public void HL7V2Tests_EvaluateHL7V2File_Message_MessageSegment()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			// Assert
			Assert.IsNull(message.Error);

			var msh = message["MSH"];

			var value = $"{Guid.NewGuid()}";

			Assert.AreEqual(msh.SegmentName, "MSH");

			// update field
			Assert.AreNotEqual(msh[2].Value, value);

			var field = msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);
			Assert.AreEqual(field.Value, value);
			Assert.AreEqual(field.Id, msh[2].Id);

			// validation
			field = msh.UpdateField(0, value);

			Assert.AreEqual(field, null);

			field = msh.UpdateField(msh.Fields.Count, value);

			Assert.AreEqual(field, null);

			msh[2].Id = 8;

			field = msh.UpdateField(2, value);

			Assert.AreEqual(field, null);

			msh[8].Id = 2;

			// insert field
			var id = msh.Fields.Count / 2;
			field = msh.InsertField(id, "_test");

			Assert.AreEqual(field.Id, id);
			Assert.AreEqual(field.Value, "_test");

			// validation
			field = msh.InsertField(0, "_test");

			Assert.AreEqual(field, null);

			field = msh.InsertField(msh.Fields.Count, "_test");

			Assert.AreEqual(field, null);

			msh[2].Id = 8;

			field = msh.InsertField(2, "_test");

			Assert.AreEqual(field, null);

			msh[8].Id = 2;

			// remove field
			var removed = msh.RemoveField(id);

			Assert.AreEqual(removed, true);

			// validation
			removed = msh.RemoveField(0);

			Assert.AreEqual(removed, false);

			// add field
			value = $"{Guid.NewGuid()}";

			field = msh.AddField(value);

			Assert.AreEqual(field.Value, value);

			Assert.AreEqual(field.Id, msh.Fields.Count + 1);

			// get field
			field = msh.GetField(5);

			Assert.AreEqual(field.Value, msh[5].Value);
			Assert.AreEqual(field.Value, message.Get("MSH.5").Value);

			// validation
			field = msh.GetField(0);

			Assert.AreEqual(field, null);

			field = msh[0];

			Assert.AreEqual(field, null);

			// to string
			var lines = File.ReadAllLines("ADT-A08 Update Patient.txt");

			message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			msh = message["MSH"];

			var messageSegmentToString = msh.ToString();

			var joinedMessageSegment = lines[0].Trim();

			Assert.AreEqual(messageSegmentToString, joinedMessageSegment);

			// validation
			message["NK1"].Fields.Clear();

			Assert.AreEqual(message["NK1"].ToString(), null);

			message["NK1"].Fields = null;

			Assert.AreEqual(message["NK1"].ToString(), null);

			// rebuild
			value = $"{Guid.NewGuid()}";

			msh[9].AddComponent(value);

			Assert.AreEqual(msh.ToString(), joinedMessageSegment);

			msh.Rebuild();

			Assert.AreNotEqual(msh.ToString(), joinedMessageSegment);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2File_Message_MessageSegment_Field()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			// Assert
			Assert.IsNull(message.Error);

			var gt16 = (HL7V2Field)message.Get("GT1.6");

			Assert.AreEqual(gt16.Delimiter, HL7V2ExpressionConfiguration.fieldDelimiter);

			Assert.AreEqual(gt16.Id, 6);

			Assert.AreEqual(gt16.Value, message["GT1"][6].Value);

			// get field repetition
			var frSplit = gt16.Value.Split(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

			Assert.AreEqual(gt16.GetFieldRepetition(1).Value, frSplit[0]);
			Assert.AreEqual(gt16.GetFieldRepetition(2).Value, frSplit[1]);
			Assert.AreEqual(gt16.GetFieldRepetition(3).Value, frSplit[2]);

			// validation
			Assert.AreEqual(gt16.GetFieldRepetition(0), null);

			// rebuild
			var value = $"{Guid.NewGuid()}";

			var oldValue = gt16.Value;

			gt16.AddFieldRepetition(value);

			Assert.AreEqual(gt16.Value, oldValue);

			gt16.Rebuild();

			Assert.AreNotEqual(gt16.Value, oldValue);

			// components
			Assert.AreEqual(gt16.Components()[0].Value, gt16[1].Value);
			Assert.AreEqual(gt16.GetComponent(1).Value, gt16[1].Value);

			// validation
			Assert.AreEqual(gt16.Components(0), null);
			Assert.AreEqual(gt16.GetComponent(0), null);

			// add component
			var previousCount = gt16.Components().Count;

			var component = gt16.AddComponent("_test");

			Assert.AreEqual(previousCount + 1, gt16.Components().Count);

			Assert.AreEqual(component.Value, "_test");

			Assert.AreEqual(component.Id, gt16.Components().Count);

			// validation
			component = gt16.AddComponent("_test", 0);

			Assert.AreEqual(component, null);

			// add component by repetition
			previousCount = gt16.Components(2).Count;

			component = gt16.AddComponent("_test", 2);

			Assert.AreEqual(previousCount + 1, gt16.Components(2).Count);

			Assert.AreEqual(component.Value, "_test");

			Assert.AreEqual(component.Id, gt16.Components(2).Count);

			// remove component
			previousCount = gt16.Components().Count;
			var removed = gt16.RemoveComponent(gt16.Components().Count);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount - 1, gt16.Components().Count);

			// validation
			removed = gt16.RemoveComponent(1, 0);

			Assert.AreEqual(removed, false);

			removed = gt16.RemoveComponent(0, 1);

			Assert.AreEqual(removed, false);

			// remove component by repetition
			previousCount = gt16.Components(2).Count;
			removed = gt16.RemoveComponent(gt16.Components(2).Count, 2);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount - 1, gt16.Components(2).Count);

			// insert component
			for (var i = 0; i < gt16.Components().Count; i++)
			{
				Assert.AreEqual(gt16.Components()[i].Id, i + 1);
			}

			var id = gt16.Components().Count / 2;
			previousCount = gt16.Components().Count;
			component = gt16.InsertComponent(id, "_test");

			Assert.AreEqual(component.Id, id);
			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(previousCount + 1, gt16.Components().Count);

			for (var i = 0; i < gt16.Components().Count; i++)
            {
				Assert.AreEqual(gt16.Components()[i].Id, i + 1);
            }

			removed = gt16.RemoveComponent(id);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount, gt16.Components().Count);

			// validation
			component = gt16.InsertComponent(0, "_test", 1);

			Assert.AreEqual(component, null);

			component = gt16.InsertComponent(1, "_test", 0);

			Assert.AreEqual(component, null);

			gt16[1].Id = 16;

			component = gt16.InsertComponent(1, "_test", 1);

			Assert.AreEqual(component, null);

			gt16[16].Id = 1;

			// insert component by repetition
			id = gt16.Components(2).Count / 2;
			previousCount = gt16.Components(2).Count;
			component = gt16.InsertComponent(id, "_test", 2);

			Assert.AreEqual(component.Id, id);
			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(previousCount + 1, gt16.Components(2).Count);

			removed = gt16.RemoveComponent(id, 2);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount, gt16.Components(2).Count);

			// update component 
			oldValue = gt16[1].Value;
			component = gt16.UpdateComponent(1, "_test");

			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(gt16[1].Value, "_test");
			Assert.AreEqual(gt16.GetFieldRepetition(1)[1].Value, "_test");

			component.Value = oldValue;

			// validation
			component = gt16.UpdateComponent(0, "_test", 1);

			Assert.AreEqual(component, null);

			component = gt16.UpdateComponent(1, "_test", 0);

			Assert.AreEqual(component, null);

			gt16[1].Id = 16;

			component = gt16.UpdateComponent(1, "_test");

			Assert.AreEqual(component, null);

			gt16[16].Id = 1;

			// update component by repetition
			oldValue = gt16[1, 2].Value;
			component = gt16.UpdateComponent(1, "_test", 2);
			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(gt16[1, 2].Value, "_test");
			Assert.AreEqual(gt16.GetFieldRepetition(2)[1].Value, "_test");

			component.Value = oldValue;

			// add field repetition
			previousCount = gt16.FieldRepetitions.Count;
			var fieldRepetition = gt16.AddFieldRepetition("_test");

			Assert.AreEqual(previousCount + 1, gt16.FieldRepetitions.Count);

			Assert.AreEqual(fieldRepetition.Value, "_test");

			Assert.AreEqual(fieldRepetition.Id, gt16.FieldRepetitions.Count);

			Assert.AreEqual(fieldRepetition.Delimiter, HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

			// remove field repetition
			removed = gt16.RemoveFieldRepetition(fieldRepetition.Id);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount, gt16.FieldRepetitions.Count);

			// validation
			removed = gt16.RemoveFieldRepetition(0);

			Assert.AreEqual(removed, false);

			// insert field repetition
			for (var i = 0; i < gt16.FieldRepetitions.Count; i++)
			{
				Assert.AreEqual(gt16.FieldRepetitions[i].Id, i + 1);
			}

			id = gt16.FieldRepetitions.Count / 2;
			previousCount = gt16.FieldRepetitions.Count;
			fieldRepetition = gt16.InsertFieldRepetition(id, "_test");

			Assert.AreEqual(fieldRepetition.Id, id);
			Assert.AreEqual(fieldRepetition.Value, "_test");
			Assert.AreEqual(previousCount + 1, gt16.FieldRepetitions.Count);

			for (var i = 0; i < gt16.FieldRepetitions.Count; i++)
			{
				Assert.AreEqual(gt16.FieldRepetitions[i].Id, i + 1);
			}

			removed = gt16.RemoveFieldRepetition(fieldRepetition.Id);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount, gt16.FieldRepetitions.Count);

			// validation
			fieldRepetition = gt16.InsertFieldRepetition(0, null);

			Assert.AreEqual(fieldRepetition, null);

			fieldRepetition = gt16.InsertFieldRepetition(gt16.FieldRepetitions.Count + 1, "_test");

			Assert.AreEqual(fieldRepetition, null);

			gt16.GetFieldRepetition(1).Id = 16;

			fieldRepetition = gt16.InsertFieldRepetition(1, "_test");

			Assert.AreEqual(fieldRepetition, null);

			gt16.GetFieldRepetition(16).Id = 1;

			// update field repetition
			gt16.Rebuild();

			oldValue = gt16.GetFieldRepetition(2).Value;

			Assert.AreNotEqual(oldValue, "_test");

			fieldRepetition = gt16.UpdateFieldRepetition(2, "_test");

			Assert.AreEqual(fieldRepetition.Value, "_test");
			Assert.AreEqual(gt16.GetFieldRepetition(2).Value, "_test");

			// validation
			fieldRepetition = gt16.UpdateFieldRepetition(0, "_test");

			Assert.AreEqual(fieldRepetition, null);

			fieldRepetition = gt16.UpdateFieldRepetition(gt16.FieldRepetitions.Count, "_test");

			Assert.AreEqual(fieldRepetition, null);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2File_Message_MessageSegment_Field_FieldRepetition()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var gt161 = (HL7V2FieldRepetition)message.Get("GT1.6(1)");

			// Assert
			Assert.IsNull(message.Error);
			
			Assert.AreEqual(gt161.Delimiter, HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);
			Assert.AreEqual(gt161.Id, 1);

			// add component
			var previousCount = gt161.Components.Count;
			var component = gt161.AddComponent("_test");

			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(component.Id, gt161.Components.Count);
			Assert.AreEqual(component.Delimiter, HL7V2ExpressionConfiguration.componentDelimiter);
			Assert.AreEqual(previousCount + 1, gt161.Components.Count);

			// remove component
			var removed = gt161.RemoveComponent(component.Id);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount, gt161.Components.Count);

			// validation
			removed = gt161.RemoveComponent(0);

			Assert.AreEqual(removed, false);

			// insert component
			for (var i = 0; i < gt161.Components.Count; i++)
			{
				Assert.AreEqual(gt161.Components[i].Id, i + 1);
			}
			var id = gt161.Components.Count / 2;
			component = gt161.InsertComponent(id, "_test");

			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(component.Id, id);
			Assert.AreEqual(component.Delimiter, HL7V2ExpressionConfiguration.componentDelimiter);

			for (var i = 0; i < gt161.Components.Count; i++)
			{
				Assert.AreEqual(gt161.Components[i].Id, i + 1);
			}

			removed = gt161.RemoveComponent(component.Id);

			// validation
			component = gt161.InsertComponent(0, "_test");

			Assert.AreEqual(component, null);

			component = gt161.InsertComponent(gt161.Components.Count + 1, "_test");

			Assert.AreEqual(component, null);

			Assert.AreEqual(removed, true);

			Assert.AreEqual(previousCount, gt161.Components.Count);

			// update component
			Assert.AreNotEqual(gt161[1].Value, "_test");

			component = gt161.UpdateComponent(1, "_test");

			Assert.AreEqual(component.Value, "_test");
			Assert.AreEqual(component.Id, 1);
			Assert.AreEqual(component.Delimiter, HL7V2ExpressionConfiguration.componentDelimiter);

			// validation
			component = gt161.UpdateComponent(0, "_test");

			Assert.AreEqual(component, null);

			component = gt161.UpdateComponent(gt161.Components.Count + 1, "_test");

			Assert.AreEqual(component, null);

			gt161[1].Id = 16;

			component = gt161.UpdateComponent(1, "_test");

			Assert.AreEqual(component, null);

			gt161[16].Id = 1;
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2File_Message_MessageSegment_Field_FieldRepetition_Component()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var pv179 = (HL7V2Component)message.Get("PV1.7.9");

			// Assert
			Assert.IsNull(message.Error);

			Assert.AreEqual(pv179.Delimiter, HL7V2ExpressionConfiguration.componentDelimiter);
			Assert.AreEqual(pv179.Id, 9);

			// add sub component
			var previousCount = pv179.SubComponents.Count;
			var subComponent = pv179.AddSubComponent("_test");

			Assert.AreEqual(subComponent.Value, "_test");
			Assert.AreEqual(subComponent.Id, pv179.SubComponents.Count);
			Assert.AreEqual(subComponent.Delimiter, HL7V2ExpressionConfiguration.subComponentDelimiter);
			Assert.AreEqual(previousCount + 1, pv179.SubComponents.Count);

			// validation
			var testSubComponent = pv179.GetSubComponent(0);

			Assert.AreEqual(testSubComponent, null);

			testSubComponent = pv179[0];

			Assert.AreEqual(testSubComponent, null);

			// remove sub component
			var removed = pv179.RemoveSubComponent(subComponent.Id);

			Assert.AreEqual(removed, true);
			Assert.AreEqual(previousCount, pv179.SubComponents.Count);

			removed = pv179.RemoveSubComponent(0);

			Assert.AreEqual(removed, false);

			// insert sub component
			for (var i = 0; i < pv179.SubComponents.Count; i++)
			{
				Assert.AreEqual(pv179.SubComponents[i].Id, i + 1);
			}
			var id = pv179.SubComponents.Count / 2;
			subComponent = pv179.InsertSubComponent(id, "_test");

			Assert.AreEqual(subComponent.Value, "_test");
			Assert.AreEqual(subComponent.Id, id);
			Assert.AreEqual(subComponent.Delimiter, HL7V2ExpressionConfiguration.subComponentDelimiter);
			for (var i = 0; i < pv179.SubComponents.Count; i++)
			{
				Assert.AreEqual(pv179.SubComponents[i].Id, i + 1);
			}

			removed = pv179.RemoveSubComponent(subComponent.Id);

			Assert.AreEqual(removed, true);

			Assert.AreEqual(previousCount, pv179.SubComponents.Count);

			// validation
			subComponent = pv179.InsertSubComponent(0, "_test");

			Assert.AreEqual(subComponent, null);

			subComponent = pv179.InsertSubComponent(pv179.SubComponents.Count + 1, "_test");

			Assert.AreEqual(subComponent, null);

			// update sub component
			Assert.AreEqual(pv179.SubComponents[0].Id, 1);

			Assert.AreNotEqual(pv179[1].Value, "_test");

			subComponent = pv179.UpdateSubComponent(1, "_test");

			Assert.AreEqual(subComponent.Value, "_test");
			Assert.AreEqual(subComponent.Id, 1);
			Assert.AreEqual(subComponent.Delimiter, HL7V2ExpressionConfiguration.subComponentDelimiter);

			// validations
			subComponent = pv179.UpdateSubComponent(0, "_test");

			Assert.AreEqual(subComponent, null);

			subComponent = pv179.UpdateSubComponent(pv179.SubComponents.Count + 1, "_test");

			Assert.AreEqual(subComponent, null);

			pv179[1].Id = 16;

			subComponent = pv179.UpdateSubComponent(1, "_test");

			Assert.AreEqual(subComponent, null);

			pv179[16].Id = 1;
		}

		[TestMethod]
		public void HL7V2Tests_HL7V2ExpressionConfiguration()
        {
			// static
			Assert.AreEqual(HL7V2ExpressionConfiguration.fieldDelimiter, "|");
			Assert.AreEqual(HL7V2ExpressionConfiguration.componentDelimiter, "^");
			Assert.AreEqual(HL7V2ExpressionConfiguration.escapeCharacter, "\\");
			Assert.AreEqual(HL7V2ExpressionConfiguration.subComponentDelimiter, "&");
			Assert.AreEqual(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter, "~");
			Assert.AreEqual(HL7V2ExpressionConfiguration.presentButNull, "\"\"");

			foreach (var ssh in HL7V2ExpressionConfiguration.specialSegmentHeaders)
            {
				var valid = new[] { "MSH", "FHS", "BHS" }.Contains(ssh);
				Assert.AreEqual(valid, true);
            }

			var ec = HL7V2ExpressionConfiguration.encodingConversions;

			Assert.AreEqual(ec[HL7V2ExpressionConfiguration.escapeCharacter], $"{HL7V2ExpressionConfiguration.escapeCharacter}E{HL7V2ExpressionConfiguration.escapeCharacter}");
			Assert.AreEqual(ec[HL7V2ExpressionConfiguration.fieldDelimiter], $"{HL7V2ExpressionConfiguration.escapeCharacter}F{HL7V2ExpressionConfiguration.escapeCharacter}");
			Assert.AreEqual(ec[HL7V2ExpressionConfiguration.fieldRepetitionDelimiter], $"{HL7V2ExpressionConfiguration.escapeCharacter}R{HL7V2ExpressionConfiguration.escapeCharacter}");
			Assert.AreEqual(ec[HL7V2ExpressionConfiguration.componentDelimiter], $"{HL7V2ExpressionConfiguration.escapeCharacter}S{HL7V2ExpressionConfiguration.escapeCharacter}");
			Assert.AreEqual(ec[HL7V2ExpressionConfiguration.subComponentDelimiter], $"{HL7V2ExpressionConfiguration.escapeCharacter}T{HL7V2ExpressionConfiguration.escapeCharacter}");

			var input = HL7V2ExpressionConfiguration.escapeCharacter;

			// encode string
			var output = HL7V2ExpressionConfiguration.EncodeString(input);

			Assert.AreEqual(ec[input], output);

			// decode string
			output = HL7V2ExpressionConfiguration.DecodeString(output);

			Assert.AreEqual(input, output);

			// rebuild encoding conversions
			HL7V2ExpressionConfiguration.escapeCharacter = "$";
			Assert.AreEqual(ec.ContainsKey(HL7V2ExpressionConfiguration.escapeCharacter), false);

			HL7V2ExpressionConfiguration.RebuildEncodingConversions();

			ec = HL7V2ExpressionConfiguration.encodingConversions;

			Assert.AreEqual(ec.ContainsKey(HL7V2ExpressionConfiguration.escapeCharacter), true);

			var expConfig = new HL7V2ExpressionConfiguration();

			Assert.AreEqual(expConfig.Operators.Count, 1);

			Assert.AreEqual(expConfig.MathStringOperators.Count, 1);

			Assert.AreEqual(expConfig.BooleanOperators.Count, 0);

			Assert.AreEqual(expConfig.Options.IgnoreParentheses, true);

			Assert.AreEqual(expConfig.Options.IgnoreWhitespaceOutsideQuotes, true);

			Assert.AreEqual(expConfig.Options.IgnoreQuotesValidation, true);

			Assert.AreEqual(expConfig.Operators[0].ExpressionOperator, Operator.Addition);
			
			Assert.AreEqual(expConfig.Operators[0].OperatorName, HL7V2ExpressionConfiguration.fieldDelimiter);

			Assert.AreNotEqual(expConfig.Operators[0].SolveOperatorExpression, null);

			Assert.AreNotEqual(expConfig.GetHL7V2MessageSegment(), null);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2File()
        {
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// invalid path
			var message = evaluator.EvaluateHL7V2File($"{Guid.NewGuid()}");

			Assert.AreNotEqual(message.Error, null);

			// invalid configuration
			evaluator = new Evaluator();
			message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			Assert.AreNotEqual(message.Error, null);

			evaluator = new Evaluator(expressionConfiguration);

			HL7V2ExpressionConfiguration.fieldDelimiter = "_test";
			HL7V2ExpressionConfiguration.componentDelimiter = "_test";
			HL7V2ExpressionConfiguration.fieldRepetitionDelimiter = "_test";
			HL7V2ExpressionConfiguration.escapeCharacter = "_test";
			HL7V2ExpressionConfiguration.subComponentDelimiter = "_test";

			// MSH|^~\&
			message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			Assert.AreEqual(HL7V2ExpressionConfiguration.fieldDelimiter, "|");
			Assert.AreEqual(HL7V2ExpressionConfiguration.componentDelimiter, "^");
			Assert.AreEqual(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter, "~");
			Assert.AreEqual(HL7V2ExpressionConfiguration.escapeCharacter, "\\");
			Assert.AreEqual(HL7V2ExpressionConfiguration.subComponentDelimiter, "&");

			Assert.AreEqual(message.Error, null);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HLV2Tests_EvaluateHL7V2File_BuildFromScratch()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			var evaluatedMessage = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			var message = new HL7V2Message();

			var msh = message.AddMessageSegment("MSH");

			var field = msh.AddField("|", false);

			Assert.AreEqual(field.FieldRepetitions.Count, 0);
			Assert.AreEqual(field.GetFieldRepetition(0), null);

			field = msh.AddField("^~\\&", false);

			Assert.AreEqual(field.FieldRepetitions.Count, 0);
			Assert.AreEqual(field.GetFieldRepetition(0), null);

			field = msh.AddField("Ntierprise");
			
			Assert.AreEqual(field.FieldRepetitions.Count, 1);
			Assert.AreEqual(field.GetFieldRepetition(1).Value, field.Value);

			field = msh.AddField("Ntierprise Clinic");

			Assert.AreEqual(field.FieldRepetitions.Count, 1);
			Assert.AreEqual(field.GetFieldRepetition(1).Value, field.Value);

			field = msh.AddField("Healthmatics EHR");

			Assert.AreEqual(field.FieldRepetitions.Count, 1);
			Assert.AreEqual(field.GetFieldRepetition(1).Value, field.Value);

			field = msh.AddField("Healthmatics Clinic");

			Assert.AreEqual(field.FieldRepetitions.Count, 1);
			Assert.AreEqual(field.GetFieldRepetition(1).Value, field.Value);

			field = msh.AddField("20190423113910");

			Assert.AreEqual(field.FieldRepetitions.Count, 1);
			Assert.AreEqual(field.GetFieldRepetition(1).Value, field.Value);

			field = msh.AddField("");

			Assert.AreEqual(field.FieldRepetitions.Count, 1);
			Assert.AreEqual(field.GetFieldRepetition(1).Value, field.Value);

			field = msh.AddField("ADT^A08");

			for (var i = 0; i < field.Components().Count; i++)
			{
				Assert.AreEqual(field.Components()[i].Id, i + 1);
			}

			Assert.AreEqual(field.Components()[0].Value, "ADT");
			Assert.AreEqual(field.Components()[1].Value, "A08");

			msh.AddField("8899-39");
			msh.AddField("P");
			msh.AddField("2.3");
			msh.AddField("");
			msh.AddField("");
			msh.AddField("NE");
			msh.AddField("NE");

			Assert.AreEqual(msh.ToString(), evaluatedMessage["MSH"].ToString());

			var evn = message.AddMessageSegment("EVN");
			evn.AddField("A08");
			evn.AddField("20190423113910");
			evn.AddField("");
			evn.AddField("01");

			Assert.AreEqual(evn.ToString(), evaluatedMessage["EVN"].ToString());

			var pid = message.AddMessageSegment("PID");
			pid.AddField("1");
			pid.AddField("");
			pid.AddField("151");
			pid.AddField("");
			pid.AddField("Bond^Tiny");
			pid.AddField("");
			pid.AddField("19990723");
			pid.AddField("M");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("8388 Secret Agent Way^^Raleigh^NC^27677");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("151");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("");
			pid.AddField("N");

			Assert.AreEqual(pid.ToString(), evaluatedMessage["PID"].ToString());

			var nk1 = message.AddMessageSegment("NK1");

			nk1.AddField("1");
			nk1.AddField("Bond^Lady^T");
			nk1.AddField("Spouse^Spouse");
			nk1.AddField("007 Soho Lane^^Cary^NC^27511");
			nk1.AddField("(919)007-0007^^PH^^^919^0070007");

			Assert.AreEqual(nk1.ToString(), evaluatedMessage["NK1"].ToString());

			var pv1 = message.AddMessageSegment("PV1");

			pv1.AddField("1");
			pv1.AddField("R");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			field = pv1.AddField("Manning^Manning^Terry^^^^^^&7654321&UPIN");

			var component = field[9];

			Assert.AreEqual(component.Value, "&7654321&UPIN");
			Assert.AreEqual(component[1].Value, "");
			Assert.AreEqual(component[2].Value, "7654321");
			Assert.AreEqual(component[3].Value, "UPIN");

			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("");
			pv1.AddField("N");
			pv1.AddField("");
			pv1.AddField("A");

			Assert.AreEqual(pv1.ToString(), evaluatedMessage["PV1"].ToString());

			var gt1 = message.AddMessageSegment("GT1");

			gt1.AddField("1");
			gt1.AddField("150");
			gt1.AddField("Bond^James^^007");
			gt1.AddField("");
			gt1.AddField("007 Soho Lane^^Cary^NC^27511");
			field = gt1.AddField("(919)007-0007^^PH^^^919^0070007~(777)707-0707^^CP^^^777^7070707~^NET^X.400^007@BritishSecretService.com");

			Assert.AreEqual(field.FieldRepetitions.Count, 3);
			Assert.AreEqual(field[1, 1].Value, "(919)007-0007");
			Assert.AreEqual(field[1, 2].Value, "(777)707-0707");
			Assert.AreEqual(field[1, 3].Value, "");

			gt1.AddField("(919)851-6177 X007^^^^^919^8516177^007");
			gt1.AddField("19770920");
			gt1.AddField("M");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("007-00-0007");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("2988 England Drive^^London^DC");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("F");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("M");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("");
			gt1.AddField("British Secret Service");

			Assert.AreEqual(gt1.ToString(), message["GT1"].ToString());

			var messageToString = message.ToString();
			var evaluatedMessageToString = evaluatedMessage.ToString();

			Assert.AreEqual(messageToString, evaluatedMessageToString);

			Assert.AreEqual(message, evaluatedMessage);
		}
	}
}
