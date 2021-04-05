using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class CustomOperatorTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void EvaluatorTest_NoParenthesesStringOnLeft()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol\"", Type = VariableType.String }; ;
			var exp = "5 * 3 / 3 + \"lol\"";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
