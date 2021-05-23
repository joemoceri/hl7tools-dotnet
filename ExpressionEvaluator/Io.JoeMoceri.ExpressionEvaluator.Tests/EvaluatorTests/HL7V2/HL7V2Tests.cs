using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
    [TestClass]
    public class HL7V2Tests
    {
		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_VerifyAllFields()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			// TODO: Fill this out
			var msh = message["MSH"];

			Assert.AreEqual(msh.GetField(3).Value, msh[3].Value);

			Assert.AreEqual(msh[3].GetFieldRepetition(1).Value, msh[3].Value);

			msh[3].Value = $"{Guid.NewGuid()}";

			message.Rebuild();

			Assert.AreEqual(msh.GetField(3).Value, msh[3].Value);

			Assert.AreEqual(msh[3].GetFieldRepetition(1).Value, msh[3].Value);

			var lines = File.ReadAllLines("ADT-A08 Update Patient.txt");

			for (var i = 0; i < lines.Length; i++)
            {
				var segmentName = lines[i].Substring(0, 3);

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

				for (var j = 0; j < split.Count; j++)
                {
					Assert.AreEqual(split[j], segment[j + 1].Value);
                }
            }

			var evn = message["EVN"];

			var pid = message["PID"];

			var nk1 = message["NK1"];

			var pv1 = message["PV1"];

			var gt1 = message["GT1"];

			// Assert
			Assert.IsNull(message.Error);
		}

		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/ADT-A08 Update Patient.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_UpdateFieldValue()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

			// TODO: Fill this out
			var msh = message["MSH"];

			var value = "testtierenterprise";

			msh.UpdateField(2, value);

			Assert.AreEqual(msh[2].Value, value);

			var evn = message["EVN"];

			var pid = message["PID"];

			var nk1 = message["NK1"];

			var pv1 = message["PV1"];

			var gt1 = message["GT1"];

			// Assert
			Assert.IsNull(message.Error);
		}
	}
}
