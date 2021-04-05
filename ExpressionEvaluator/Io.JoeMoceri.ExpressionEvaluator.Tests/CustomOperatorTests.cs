using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class CustomOperatorTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void CustomOperatorTests_AdditionOnBeforeOperatorExpressionSolvedTest()
		{
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnBeforeOperatorExpressionSolved = (expGroup) =>
			{
				count++;
			};

			solver = new Evaluator(languageTemplate);

			var answer = new ExpressionResult 
			{
				Value = "3", Type = VariableType.Int 
			};

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			Assert.AreEqual(count, 1);

			solver.Evaluate(exp);

			Assert.AreEqual(count, 2);

			additionOperator.OnBeforeOperatorExpressionSolved = null;

			solver.Evaluate(exp);

			// shouldn't be called
			Assert.AreEqual(count, 2);
		}

		[TestMethod]
		public void CustomOperatorTests_AdditionOnAfterOperatorExpressionSolvedTest()
		{
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnAfterOperatorExpressionSolved = (expressionResult) =>
			{
				// the expression is known, so this is safe, and the point. You're in control.
				var v = int.Parse(expressionResult.Value);

				count += v;
			};

			solver = new Evaluator(languageTemplate);

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(count, 3);

			solver.Evaluate(exp);

			Assert.AreEqual(count, 6);

			additionOperator.OnAfterOperatorExpressionSolved = null;

			solver.Evaluate(exp);

			// shouldn't be called
			Assert.AreEqual(count, 6);
		}

		[TestMethod]
		public void CustomOperatorTests_AdditionSolveOperatorExpression()
		{
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				return new ExpressionResult
				{
					Value = "0",
					Type = VariableType.Int
				};
			};

			solver = new Evaluator(languageTemplate);

			var answer = new ExpressionResult
			{
				Value = "0",
				Type = VariableType.Int
			};

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
