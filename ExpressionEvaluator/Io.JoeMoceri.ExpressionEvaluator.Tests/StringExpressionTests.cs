using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class StringArithmeticTest_ExpressionTests
	{

		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void StringArithmetic_Single()
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
		public void StringArithmetic_TwoStringAddition()
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
		public void StringArithmetic_ThreeStringAddition()
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
		public void StringArithmetic_ThreeOperandExpression()
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
		public void StringArithmetic_LeftStringAddition()
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
		public void StringArithmetic_LeftStringMultiplication()
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
		public void StringArithmetic_RightStringAddition()
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
		public void StringArithmetic_RightStringMultiplication()
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
		public void StringArithmetic_RightStringMultiplication_EscapedDoubleQuote()
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
		public void StringArithmetic_ParenthesesLeftMultiplication()
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
		public void StringArithmetic_ParenthesesRightMultiplication()
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
		public void StringArithmetic_NestedParentheses()
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
		public void StringArithmetic_NestedParenthesesInsideLeftParentheses()
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
		public void StringArithmetic_NestedParenthesesInsideRightParentheses()
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
		public void StringArithmetic_NestedParenthesesInsideBothParentheses()
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
		public void StringArithmetic_NestedParenthesesExpression()
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
		public void String01()
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
		public void String02()
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
		public void String03()
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
		public void String04()
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
		public void String05()
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
		public void String06()
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
		public void String07()
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
		public void String08()
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
		public void String09()
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
		public void String10()
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
		public void String11()
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
		public void String12()
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
		public void String13()
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
		public void String14()
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
		public void String15()
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
		public void String16()
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
		public void String17()
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
		public void String18()
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
		public void String19()
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
		public void String20()
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
		public void String21()
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
