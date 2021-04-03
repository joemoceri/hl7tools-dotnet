using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class ErrorTests
	{
		private Evaluator solver = new Evaluator(new Arithmetic());

		[TestMethod]
		public void BadInput_ShouldReturnExpressionResultWithNullValuesAndException()
		{
			var result = solver.Evaluate("asdjhas;dglasd;a;s");
			Assert.IsNotNull(result.Error);
		}
	}
}
