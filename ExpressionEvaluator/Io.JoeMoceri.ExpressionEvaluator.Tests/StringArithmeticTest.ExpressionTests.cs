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

	}
}
