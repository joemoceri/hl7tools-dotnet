using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class MathArithmeticTest
	{
		private Evaluator solver = new Evaluator(new ArithmeticService());

		[TestMethod]
		public void MathArithmetic_NoParentheses()
		{
			// Arrange
			var ans = 4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5;
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
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
			var ans = (((((4.563) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3));
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
			var exp = "(((((4.563) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathArithmetic_NestedOverallParenthesesNegative()
		{
			// Arrange
			var ans = (((((-4.563) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3));
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
			var exp = "(((((-4.563) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3))";

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var ans = 4.563 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
			var exp = "4.563 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3)";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}
		
		[TestMethod]
		public void MathArithmetic_SameLevelParenthesesNegative()
		{
			// Arrange
			var ans = -4.563 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
			var exp = "-4.563 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3)";

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var ans = -4.563 + -12 - -3 * -(-4 + -3);
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Float };
			var exp = "-4.563 + -12 - -3 * -(-4 + -3)";

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.Int };
			var exp = "-5 - -10";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
