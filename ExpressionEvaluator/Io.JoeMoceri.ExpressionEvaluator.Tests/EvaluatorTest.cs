using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class EvaluatorTest
	{
		private Evaluator solver = new Evaluator(new ArithmeticService());

		[TestMethod]
		public void EvaluatorTest_NoParenthesesStringOnLeft()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol\"", Type = VarType.String }; ;
			var exp = "5 * 3 / 3 + \"lol\"";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_SingleParenthesesForString()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol\"", Type = VarType.String }; ;
			var exp = "5 * 3 / 3 + (\"lol\")";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_ParenthesesForStringAddition()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol5\"", Type = VarType.String }; ;
			var exp = "5 * 3 / 3 + (\"lol\" + 5)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_NestedParenthesesForString()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol5\"", Type = VarType.String }; ;
			var exp = "5 * 3 / 3 + ((\"lol\") + 5)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_NestedParenthesesForStringAddition()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "\"5lol75\"", Type = VarType.String }; ;
			var exp = "5 * 3 / 3 + ((\"lol\") + (5 * 15))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanTrue()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "True", Type = VarType.Boolean };
			var exp = "True";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanFalse()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "False", Type = VarType.Boolean };
			var exp = "False";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanSingleParentheses()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "False", Type = VarType.Boolean };
			var exp = "(False)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanDoubleParentheses()
		{
			// Arrange
			var answer = new ExpressionResult { Value = "False", Type = VarType.Boolean };
			var exp = "((False))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_IndexOfOutsideQuotesForString()
		{
			var expression = "5 > 3 + 5";
			int result = expression.IndexOfOutsideQuotes(">");

			Assert.IsTrue(result != -1);
		}

		[TestMethod]
		public void EvaluatorTest_IndexOfOutsideQuotesForString02()
		{
			var expression = "5 >= 3 + 5";
			int result = expression.IndexOfOutsideQuotes(">=");

			Assert.IsTrue(result != -1);
		}

		[TestMethod]
		public void EvaluatorTest_IndexOfOutsideQuotesForString03()
		{
			var expression = "true and true + 5";
			int result = expression.IndexOfOutsideQuotes("and");

			Assert.IsTrue(result != -1);
		}

		[TestMethod]
		public void EvaluatorTest_IndexOfOutsideQuotesForString04()
		{
			var expression = "true \"and\" or true + 5";
			int result = expression.IndexOfOutsideQuotes("and");

			Assert.IsTrue(result == -1);
		}

		[TestMethod]
		public void EvaluatorTest_IndexOfOutsideQuotesForString05()
		{
			var expression = "true + \"and\" or true + 5";
			int result = expression.IndexOfOutsideQuotes("or");

			Assert.IsTrue(result != -1);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanStandard01() 
		{
			// Arrange
			var ans = 2 + 3 > 1 - 4 && 3 > 2;
			var expression = "2 + 3 > 1 - 4 && 3 > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanStandard02()
		{
			// Arrange
			var ans = 1 > 2;
			var expression = "1 > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanStandard03()
		{
			// Arrange
			var ans = (5 / 3) > 2;
			var expression = "(5 / 3) > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanStandard04()
		{
			// Arrange
			var ans = -(-1 - -2) > -(-3 - -4);
			var expression = "-(-1 - -2) > -(-3 - -4)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanStandard05()
		{
			// Arrange
			var ans = 2 > 1 == true;
			var expression = "2 > 1 == True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTest_BooleanStandard06()
		{
			// Arrange
			var ans = 2 > 1 != true;
			var expression = "2 > 1 != True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Boolean };
			
			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
