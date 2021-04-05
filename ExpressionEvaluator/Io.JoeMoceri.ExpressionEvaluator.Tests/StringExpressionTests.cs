using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class StringExpressionTests
	{

		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void StringExpressionTests_Single()
		{
			// Arrange
			var check = " \" ab + \"";
			var answer = new ExpressionResult { Value = "\" ab + \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_TwoStringAddition()
		{
			// Arrange
			var check = " \" ab + \" + \" cd \"";
			var answer = new ExpressionResult { Value = "\" ab +  cd \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_ThreeStringAddition()
		{
			// Arrange
			var check = " \" ab + \" + \" cd \" + \" ef \"";
			var answer = new ExpressionResult { Value = "\" ab +  cd  ef \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_ThreeOperandExpression()
		{
			// Arrange
			var check = " \" ab + \" + \" cd \" * 3";
			var answer = new ExpressionResult { Value = "\" ab +  cd  cd  cd \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_LeftStringAddition()
		{
			// Arrange
			var check = " \" ab + \" + 3";
			var answer = new ExpressionResult { Value = "\" ab + 3\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_LeftStringMultiplication()
		{
			// Arrange
			var check = " \" ab + \" * 3";
			var answer = new ExpressionResult { Value = "\" ab +  ab +  ab + \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_RightStringAddition()
		{
			// Arrange
			var check = " 4 + \" cd \"";
			var answer = new ExpressionResult { Value = "\"4 cd \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_RightStringMultiplication()
		{
			// Arrange
			var check = " 4 * \" cd \"";
			var answer = new ExpressionResult { Value = "\" cd  cd  cd  cd \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_RightStringMultiplication_EscapedDoubleQuote()
		{
			// Arrange
			var check = " 4 * \" \\\"cd \"";
			var answer = new ExpressionResult { Value = "\" \\\"cd  \\\"cd  \\\"cd  \\\"cd \"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_ParenthesesLeftMultiplication()
		{
			// Arrange
			var check = " 4 * (\" cd \" + \"lol\")";
			var answer = new ExpressionResult { Value = "\" cd lol cd lol cd lol cd lol\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_ParenthesesRightMultiplication()
		{
			// Arrange
			var check = "(\" cd \" + \"lol\") * 4  ";
			var answer = new ExpressionResult { Value = "\" cd lol cd lol cd lol cd lol\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParentheses()
		{
			// Arrange
			var check = "(\" cd \" + (\"lol\")) * 4  ";
			var answer = new ExpressionResult { Value = "\" cd lol cd lol cd lol cd lol\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesInsideLeftParentheses()
		{
			// Arrange
			var check = "(\" cd \" + (\"lol(\")) * 4  ";
			var answer = new ExpressionResult { Value = "\" cd lol( cd lol( cd lol( cd lol(\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesInsideRightParentheses()
		{
			// Arrange
			var check = "(\" cd \" + (\"lol)\")) * 4  ";
			var answer = new ExpressionResult { Value = "\" cd lol) cd lol) cd lol) cd lol)\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesInsideBothParentheses()
		{
			// Arrange
			var check = "(\" cd \" + (\"(lol)\")) * 4  ";
			var answer = new ExpressionResult { Value = "\" cd (lol) cd (lol) cd (lol) cd (lol)\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesExpression()
		{
			// Arrange
			var check = "(\" cd \" + (\"lol\" + \"lmao\")) * 4  ";
			var answer = new ExpressionResult { Value = "\" cd lollmao cd lollmao cd lollmao cd lollmao\"", Type = VariableType.String };

			// Act
			var result = solver.Evaluate(check);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_String01()
		{
			// Arrange
			var ans = "\"test\"";
			var expression = "\"test\"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String02()
		{
			// Arrange
			var ans = "\" test \"";
			var expression = "\" test \"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String03()
		{
			// Arrange
			var ans = "\" \\\"test \"";
			var expression = "\" \\\"test \"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String04()
		{
			// Arrange
			var ans = "\"test \"";
			var expression = "\"test \"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String05()
		{
			// Arrange
			var ans = "\" test\"";
			var expression = "\" test\"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String06()
		{
			// Arrange
			var ans = "\" test " + "test2\"";
			var expression = "\" test \" + \"test2\"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String07()
		{
			// Arrange
			var ans = "\" test " + 1 + "\"";
			var expression = "\" test \" + 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String08()
		{
			// Arrange
			var ans = "\"" + 1 + " test \"";
			var expression = "1 + \" test \"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String09()
		{
			// Arrange
			var ans = "\" test  test \"";
			var expression = "2 * \" test \"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String10()
		{
			// Arrange
			var ans = "\" test  test \"";
			var expression = "\" test \" * 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String11()
		{
			// Arrange
			var ans = "\" test  test 3\"";
			var expression = "\" test \" * 2 + 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String12()
		{
			// Arrange
			var ans = "\"3 test  test \"";
			var expression = "3 + \" test \" * 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String13()
		{
			// Arrange
			var ans = "\"3 test  test 3\"";
			var expression = "3 + \" test \" * 2 + 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String14()
		{
			// Arrange
			var ans = "\"7 test  test 8\"";
			var expression = "( 3 + 4 ) + \" test \" * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String15()
		{
			// Arrange
			var ans = "\"7 test  test 8\"";
			var expression = "( 3 + 4 ) + (\" test \") * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String16()
		{
			// Arrange
			var ans = "\"7 test 6 test 68\"";
			var expression = "( 3 + 4 ) + (\" test \" + 6) * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String17()
		{
			// Arrange
			var ans = "\"7 test 6  test 6 8\"";
			var expression = "( 3 + 4 ) + (\" test \" + 6 + \" \") * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String18()
		{
			// Arrange
			var ans = "\"7 test 6  test 6 8\"";
			var expression = "( 3 + 4 ) + (\" test \" + 6 + \" \") * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String19()
		{
			// Arrange
			var ans = "\"7 test        test       8\"";
			var expression = "( 3 + 4 ) + (\" test \" + (6) * (\" \")) * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String20()
		{
			// Arrange
			var ans = "\"test\"";
			var expression = "(\"test\")";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String21()
		{
			// Arrange
			var ans = "\"7 test 6test2 test 6test28\"";
			var expression = "( 3 + 4 ) + ((\" test \" + (6)) + (\"test2\")) * 2 + ( 3 + 5)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}
	}
}
