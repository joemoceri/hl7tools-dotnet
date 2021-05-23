using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
    [TestClass]
    public class HL7V2Tests
    {
		[TestMethod]
		[DeploymentItem("EvaluatorTests/HL7V2/sample-messages/sample-hl7v2-message.1.txt")]
		public void HL7V2Tests_EvaluateHL7V2Message_VerifyAllFields()
		{
			// Arrange
			var expressionConfiguration = new HL7V2ExpressionConfiguration();

			var evaluator = new Evaluator(expressionConfiguration);

			// Act
			var message = evaluator.EvaluateHL7V2File("sample-hl7v2-message.1.txt");

			// TODO: Fill this out

			// Assert
			Assert.IsNull(message.Error);
		}
	}
}
