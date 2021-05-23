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
				var segmentName = lines[i].Substring(0, 3);

				// check the segment name
				Assert.AreEqual(segmentName, message.MessageSegments[i].SegmentName);

				lines[i] = lines[i].Remove(0, 4);
				// Compare this to the message Values, they should be the same and order should be respected
				// TODO: Check for the rest
				var split = lines[i].Split(HL7V2ExpressionConfiguration.fieldDelimiter).ToList();

				if (segmentName.Equals("MSH"))
				{
					split.Insert(0, HL7V2ExpressionConfiguration.fieldDelimiter);
				}

				var segment = message.MessageSegments[i];

				// check field values
				for (var j = 0; j < split.Count; j++)
				{
					Assert.AreEqual(split[j], segment[j + 1].Value);

					// check field repetitions
					// inside field repetitions, check components
					// inside components, check sub components
				}
			}
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_CompareFileWithMessage()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			CompareFileWithMessage("ADT-A08 Update Patient.txt", message);

			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_MessageSegment_UpdateField()
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
	}
}
