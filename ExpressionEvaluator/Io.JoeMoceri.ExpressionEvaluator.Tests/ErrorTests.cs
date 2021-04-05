using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class ErrorTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void ErrorTests_BadInput_ShouldReturnExpressionResultWithNullValuesAndException()
		{
			var result = solver.Evaluate("asdjhas;dglasd;a;s");

			Assert.IsNull(result.Type);
			Assert.IsNull(result.Value);
			Assert.IsNotNull(result.Error);
		}
	}
}
