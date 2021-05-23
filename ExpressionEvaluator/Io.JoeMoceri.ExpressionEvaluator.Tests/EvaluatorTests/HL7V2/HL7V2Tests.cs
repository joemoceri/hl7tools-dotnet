using Microsoft.VisualStudio.TestTools.UnitTesting;

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

			// Assert
			Assert.IsNull(message.Error);
		}
	}
}
