using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class MathExpressionTests
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void MathArithmetic_NoParentheses()
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
		public void MathArithmetic_NoParenthesesNegative()
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
		public void MathArithmetic_NestedOverallParentheses()
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
		public void MathArithmetic_NestedOverallParenthesesNegative()
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
		public void MathArithmetic_NestedSingleParentheses()
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
		public void MathArithmetic_NestedSingleParenthesesNegative()
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
		public void MathArithmetic_ParenthesesNegative()
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
		public void MathArithmetic_SameLevelParentheses()
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
		public void MathArithmetic_SameLevelParenthesesNegative()
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
		public void MathArithmetic_SolveDoubleNegative()
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
		public void MathArithmetic_SameLevelParenthesesNegativeSamePrecedence()
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
		public void MathArithmetic_SolveNegative()
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
		public void MathArithmetic_SolveNegativeWithoutEnd()
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
		public void MathArithmetic_SolveNegativeBeginning()
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
		public void MathArithmetic_Single()
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
		public void MathArithmetic_SingleNegative()
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
		public void Math01()
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
		public void Math02()
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
		public void Math03()
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
		public void Math04()
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
		public void Math05()
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
		public void Math06()
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
		public void Math07()
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
		public void Math08()
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
		public void Math09()
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
		public void Math10()
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
		public void Math11()
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
		public void Math12()
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
		public void Math13()
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
		public void Math14()
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
		public void Math15()
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
		public void Math16()
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
		public void Math17()
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
		public void Math18()
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
		public void Math19()
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
		public void Math20()
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
		public void Math21()
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
		public void Math22()
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
		public void Math23()
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
		public void Math24()
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
		public void Math25()
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
		public void Math26()
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
		public void Math27()
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
		public void Math28()
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
