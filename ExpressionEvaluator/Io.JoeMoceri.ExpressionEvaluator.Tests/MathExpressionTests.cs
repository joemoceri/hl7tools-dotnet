using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class MathExpressionTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void MathExpressionTests_NoParentheses()
		{
			// Arrange
			var ans = 4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Float };
			var exp = "4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5";
			
			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NoParenthesesNegative()
		{
			// Arrange
			var ans = -4.563 + -12 * -3 * -4 + -3 / -3 - -4 * -2 + -3 + -12 % -5;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Float };
			var exp = "-4.563 + -12 * -3 * -4 + -3 / -3 - -4 * -2 + -3 + -12 % -5";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedOverallParentheses()
		{
			// Arrange
			var ans = (((((4) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3));
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "(((((4) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedOverallParenthesesNegative()
		{
			// Arrange
			var ans = (((((-4) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3));
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "(((((-4) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedSingleParentheses()
		{
			// Arrange
			var ans = (((5 + 3)));
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "((( 5 + 3 )))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedSingleParenthesesNegative()
		{
			// Arrange
			var ans = -(-(-(5 + 3)));
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-(-(-( 5 + 3 )))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_ParenthesesNegative()
		{
			// Arrange
			var ans = -(5 + 3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-(5 + 3)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SameLevelParentheses()
		{
			// Arrange
			var ans = 4 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "4 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}
		
		[TestMethod]
		public void MathExpressionTests_SameLevelParenthesesNegative()
		{
			// Arrange
			var ans = -4 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-4 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SolveDoubleNegative()
		{
			// Arrange
			var ans = -3 - -(-4 * -2 + -3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-3 - -(-4 * -2 + -3)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SameLevelParenthesesNegativeSamePrecedence()
		{
			// Arrange
			var ans = -4 + -12 - -3 * -(-4 + -3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-4 + -12 - -3 * -(-4 + -3)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SolveNegative()
		{
			// Arrange
			var ans = 3 + -3;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "3 + -3";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}


		[TestMethod]
		public void MathExpressionTests_SolveNegativeWithoutEnd()
		{
			// Arrange
			var ans = 3 + -3 + 4;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "3 + -3 + 4";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SolveNegativeBeginning()
		{
			// Arrange
			var ans = -3 + 3 + 4;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-3 + 3 + 4";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Single()
		{
			// Arrange
			var ans = 10;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "10";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SingleNegative()
		{
			// Arrange
			var ans = -5 - -10;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };
			var exp = "-5 - -10";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math01()
		{
			// Arrange
			var ans = 1 + 2;
			var expression = "1 + 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math02()
		{
			// Arrange
			var ans = 1 + 2 - 3;
			var expression = "1 + 2 - 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math03()
		{
			// Arrange
			var ans = 1 + 2 * 3;
			var expression = "1 + 2 * 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math04()
		{
			// Arrange
			var ans = 1 * 2 + 3;
			var expression = "1 * 2 + 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math05()
		{
			// Arrange
			var ans = 1 * 2 * 3;
			var expression = "1 * 2 * 3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math06()
		{
			// Arrange
			var ans = 1 - 2;
			var expression = "1 - 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math07()
		{
			// Arrange
			var ans = 1 * 2;
			var expression = "1 * 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math08()
		{
			// Arrange
			var ans = 1 / 2;
			var expression = "1 / 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math09()
		{
			// Arrange
			var ans = 1 % 2;
			var expression = "1 % 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math10()
		{
			// Arrange
			var ans = 1;
			var expression = "1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math11()
		{
			// Arrange
			var ans = -1;
			var expression = "-1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math12()
		{
			// Arrange
			var ans = -1 + -2;
			var expression = "-1 + -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math13()
		{
			// Arrange
			var ans = -1 - -2;
			var expression = "-1 - -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math14()
		{
			// Arrange
			var ans = -1 * -2;
			var expression = "-1 * -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math15()
		{
			// Arrange
			var ans = -1 % -2;
			var expression = "-1 % -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math16()
		{
			// Arrange
			var ans = -1 / -2;
			var expression = "-1 / -2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math17()
		{
			// Arrange
			var ans = -1 + -2 * -3;
			var expression = "-1 + -2 * -3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math18()
		{
			// Arrange
			var ans = -1 * -2 + -3;
			var expression = "-1 * -2 + -3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math19()
		{
			// Arrange
			var ans = -1 - -2 - -3;
			var expression = "-1 - -2 - -3";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math20()
		{
			// Arrange
			var ans = (1);
			var expression = "(1)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math21()
		{
			// Arrange
			var ans = (-1);
			var expression = "(-1)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math22()
		{
			// Arrange
			var ans = (1 + 2);
			var expression = "(1 + 2)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math23()
		{
			// Arrange
			var ans = (1 + 2 - 3);
			var expression = "(1 + 2 - 3)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math24()
		{
			// Arrange
			var ans = ((1) + (2) - (3));
			var expression = "((1) + (2) - (3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math25()
		{
			// Arrange
			var ans = -(-(-1) + -(-2) - -(-3));
			var expression = "-(-(-1) + -(-2) - -(-3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math26()
		{
			// Arrange
			var ans = -(-(-(-1) + -(-2)) - -(-3));
			var expression = "-(-(-(-1) + -(-2)) - -(-3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math27()
		{
			// Arrange
			var ans = -(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3));
			var expression = "-(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Int };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math28()
		{
			// Arrange
			float ans = -(-(-(-1.25f * 2.5f + (3.75f / 3f) - 4.01f * 4.03f / (5.00f) % 6.0f) + -(-2.1234567890f)) - -(-3.000f));
			var expression = "-(-(-(-1.25 * 2.5 + (3.75 / 3) - 4.01 * 4.03 / (5.00) % 6.0) + -(-2.1234567890)) - -(-3.000))";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Float };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
