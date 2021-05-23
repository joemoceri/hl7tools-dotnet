using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
    [TestClass]
    public class HL7V2Tests
    {
		private void CompareFileWithMessage(string path, HL7V2Message message)
        {
			var lines = File.ReadAllLines(path);

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
		public void HL7V2Tests_EvaluateHL7V2Message_CompareFileWithMessage()
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
		public void HL7V2Tests_EvaluateHL7V2Message_Message()
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

			var value = $"{Guid.NewGuid()}";

			Assert.AreNotEqual(msh[2].Value, value);

			msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

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

			msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

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
