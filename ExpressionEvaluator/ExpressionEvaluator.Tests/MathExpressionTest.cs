using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpressionEvaluator.Services;
using ExpressionEvaluator.Controllers;
using ExpressionEvaluator.Models;
using ExpressionEvaluator.Utilities;

namespace ExpressionEvaluator_UnitTesting
{
	[TestClass]
	public class MathExpressionTest
	{
		private ArithmeticController solver = new ArithmeticController(new ArithmeticService());

		[TestMethod]
		public void Math01()
		{
			// Arrange
			var ans = 1 + 2;
			var expression = "1 + 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);
			
			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math02()
		{
			// Arrange
			var ans = 1 + 2 - 3;
			var expression = "1 + 2 - 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math03()
		{
			// Arrange
			var ans = 1 + 2 * 3;
			var expression = "1 + 2 * 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math04()
		{
			// Arrange
			var ans = 1 * 2 + 3;
			var expression = "1 * 2 + 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math05()
		{
			// Arrange
			var ans = 1 * 2 * 3;
			var expression = "1 * 2 * 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math06()
		{
			// Arrange
			var ans = 1 - 2;
			var expression = "1 - 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math07()
		{
			// Arrange
			var ans = 1 * 2;
			var expression = "1 * 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math08()
		{
			// Arrange
			var ans = 1 / 2;
			var expression = "1 / 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math09()
		{
			// Arrange
			var ans = 1 % 2;
			var expression = "1 % 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math10()
		{
			// Arrange
			var ans = 1;
			var expression = "1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math11()
		{
			// Arrange
			var ans = -1;
			var expression = "-1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math12()
		{
			// Arrange
			var ans = -1 + -2;
			var expression = "-1 + -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math13()
		{
			// Arrange
			var ans = -1 - -2;
			var expression = "-1 - -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math14()
		{
			// Arrange
			var ans = -1 * -2;
			var expression = "-1 * -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math15()
		{
			// Arrange
			var ans = -1 % -2;
			var expression = "-1 % -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math16()
		{
			// Arrange
			var ans = -1 / -2;
			var expression = "-1 / -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math17()
		{
			// Arrange
			var ans = -1 + -2 * -3;
			var expression = "-1 + -2 * -3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math18()
		{
			// Arrange
			var ans = -1 * -2 + -3;
			var expression = "-1 * -2 + -3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math19()
		{
			// Arrange
			var ans = -1 - -2 - -3;
			var expression = "-1 - -2 - -3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math20()
		{
			// Arrange
			var ans = (1);
			var expression = "(1)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math21()
		{
			// Arrange
			var ans = (-1);
			var expression = "(-1)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math22()
		{
			// Arrange
			var ans = (1 + 2);
			var expression = "(1 + 2)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math23()
		{
			// Arrange
			var ans = (1 + 2 - 3);
			var expression = "(1 + 2 - 3)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math24()
		{
			// Arrange
			var ans = ((1) + (2) - (3));
			var expression = "((1) + (2) - (3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math25()
		{
			// Arrange
			var ans = -(-(-1) + -(-2) - -(-3));
			var expression = "-(-(-1) + -(-2) - -(-3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math26()
		{
			// Arrange
			var ans = -(-(-(-1) + -(-2)) - -(-3));
			var expression = "-(-(-(-1) + -(-2)) - -(-3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math27()
		{
			// Arrange
			var ans = -(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3));
			var expression = "-(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Math28()
		{
			// Arrange
			float ans = -(-(-(-1.25f * 2.5f + (3.75f / 3f) - 4.01f * 4.03f / (5.00f) % 6.0f) + -(-2.1234567890f)) - -(-3.000f));
			var expression = "-(-(-(-1.25 * 2.5 + (3.75 / 3) - 4.01 * 4.03 / (5.00) % 6.0) + -(-2.1234567890)) - -(-3.000))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
