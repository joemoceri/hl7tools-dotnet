using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class EvaluatorTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void EvaluatorTests_NoParenthesesStringOnLeft()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5example\"", Type = VariableType.String };
			var exp = "5 * 3 / 3 + \"example\"";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);


		}

		[TestMethod]
		public void EvaluatorTests_SingleParenthesesForString()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5example2\"", Type = VariableType.String };
			var exp = "5 * 3 / 3 + (\"example2\")";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_ParenthesesForStringAddition()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5example25\"", Type = VariableType.String }; ;
			var exp = "5 * 3 / 3 + (\"example2\" + 5)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_NestedParenthesesForString()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol5\"", Type = VariableType.String }; ;
			var exp = "5 * 3 / 3 + ((\"lol\") + 5)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_NestedParenthesesForStringAddition()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5example275\"", Type = VariableType.String }; ;
			var exp = "5 * 3 / 3 + ((\"example2\") + (5 * 15))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanTrue()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "True", Type = VariableType.Boolean };
			var exp = "True";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanFalse()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "False", Type = VariableType.Boolean };
			var exp = "False";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanSingleParentheses()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "False", Type = VariableType.Boolean };
			var exp = "(False)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanDoubleParentheses()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "False", Type = VariableType.Boolean };
			var exp = "((False))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard01() 
		{
			// Arrange
			var ans = 2 + 3 > 1 - 4 && 3 > 2;
			var expression = "2 + 3 > 1 - 4 && 3 > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard02()
		{
			// Arrange
			var ans = 1 > 2;
			var expression = "1 > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard03()
		{
			// Arrange
			var ans = (5 / 3) > 2;
			var expression = "(5 / 3) > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard04()
		{
			// Arrange
			var ans = -(-1 - -2) > -(-3 - -4);
			var expression = "-(-1 - -2) > -(-3 - -4)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard05()
		{
			// Arrange
			var ans = 2 > 1 == true;
			var expression = "2 > 1 == True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard06()
		{
			// Arrange
			var ans = 2 > 1 != true;
			var expression = "2 > 1 != True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
