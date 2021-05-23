using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class CSharpMathExpressionTests
	{
		[TestMethod]
		public void MathExpressionTests_NoParentheses()
		{
			// Arrange
			var expressionAnswer = 4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5;
			var expression = "4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Float 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NoParenthesesNegative()
		{
			// Arrange
			var expressionAnswer = -4.563 + -12 * -3 * -4 + -3 / -3 - -4 * -2 + -3 + -12 % -5;
			var expression = "-4.563 + -12 * -3 * -4 + -3 / -3 - -4 * -2 + -3 + -12 % -5";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Float 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedOverallParentheses()
		{
			// Arrange
			var expressionAnswer = (((((4) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3));
			var expression = "(((((4) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedOverallParenthesesNegative()
		{
			// Arrange
			var expressionAnswer = (((((-4) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3));
			var expression = "(((((-4) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedSingleParentheses()
		{
			// Arrange
			var expressionAnswer = (((5 + 3)));
			var expression = "((( 5 + 3 )))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_NestedSingleParenthesesNegative()
		{
			// Arrange
			var expressionAnswer = -(-(-(5 + 3)));
			var expression = "-(-(-( 5 + 3 )))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_ParenthesesNegative()
		{
			// Arrange
			var expressionAnswer = -(5 + 3);
			var expression = "-(5 + 3)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SameLevelParentheses()
		{
			// Arrange
			var expressionAnswer = 4 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3);
			var expression = "4 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}
		
		[TestMethod]
		public void MathExpressionTests_SameLevelParenthesesNegative()
		{
			// Arrange
			var expressionAnswer = -4 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3);
			var expression = "-4 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SolveDoubleNegative()
		{
			// Arrange
			var expressionAnswer = -3 - -(-4 * -2 + -3);
			var expression = "-3 - -(-4 * -2 + -3)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SameLevelParenthesesNegativeSamePrecedence()
		{
			// Arrange
			var expressionAnswer = -4 + -12 - -3 * -(-4 + -3);
			var expression = "-4 + -12 - -3 * -(-4 + -3)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SolveNegative()
		{
			// Arrange
			var expressionAnswer = 3 + -3;
			var expression = "3 + -3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}


		[TestMethod]
		public void MathExpressionTests_SolveNegativeWithoutEnd()
		{
			// Arrange
			var expressionAnswer = 3 + -3 + 4;
			var expression = "3 + -3 + 4";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SolveNegativeBeginning()
		{
			// Arrange
			var expressionAnswer = -3 + 3 + 4;
			var expression = "-3 + 3 + 4";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Single()
		{
			// Arrange
			var expressionAnswer = 10;
			var expression = "10";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_SingleNegative()
		{
			// Arrange
			var expressionAnswer = -5 - -10;
			var expression = "-5 - -10";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math01()
		{
			// Arrange
			var expressionAnswer = 1 + 2;
			var expression = "1 + 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math02()
		{
			// Arrange
			var expressionAnswer = 1 + 2 - 3;
			var expression = "1 + 2 - 3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math03()
		{
			// Arrange
			var expressionAnswer = 1 + 2 * 3;
			var expression = "1 + 2 * 3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math04()
		{
			// Arrange
			var expressionAnswer = 1 * 2 + 3;
			var expression = "1 * 2 + 3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math05()
		{
			// Arrange
			var expressionAnswer = 1 * 2 * 3;
			var expression = "1 * 2 * 3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math06()
		{
			// Arrange
			var expressionAnswer = 1 - 2;
			var expression = "1 - 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math07()
		{
			// Arrange
			var expressionAnswer = 1 * 2;
			var expression = "1 * 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math08()
		{
			// Arrange
			var expressionAnswer = 1 / 2;
			var expression = "1 / 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math09()
		{
			// Arrange
			var expressionAnswer = 1 % 2;
			var expression = "1 % 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math10()
		{
			// Arrange
			var expressionAnswer = 1;
			var expression = "1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math11()
		{
			// Arrange
			var expressionAnswer = -1;
			var expression = "-1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math12()
		{
			// Arrange
			var expressionAnswer = -1 + -2;
			var expression = "-1 + -2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math13()
		{
			// Arrange
			var expressionAnswer = -1 - -2;
			var expression = "-1 - -2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math14()
		{
			// Arrange
			var expressionAnswer = -1 * -2;
			var expression = "-1 * -2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math15()
		{
			// Arrange
			var expressionAnswer = -1 % -2;
			var expression = "-1 % -2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math16()
		{
			// Arrange
			var expressionAnswer = -1 / -2;
			var expression = "-1 / -2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math17()
		{
			// Arrange
			var expressionAnswer = -1 + -2 * -3;
			var expression = "-1 + -2 * -3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math18()
		{
			// Arrange
			var expressionAnswer = -1 * -2 + -3;
			var expression = "-1 * -2 + -3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math19()
		{
			// Arrange
			var expressionAnswer = -1 - -2 - -3;
			var expression = "-1 - -2 - -3";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math20()
		{
			// Arrange
			var expressionAnswer = (1);
			var expression = "(1)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math21()
		{
			// Arrange
			var expressionAnswer = (-1);
			var expression = "(-1)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math22()
		{
			// Arrange
			var expressionAnswer = (1 + 2);
			var expression = "(1 + 2)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math23()
		{
			// Arrange
			var expressionAnswer = (1 + 2 - 3);
			var expression = "(1 + 2 - 3)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math24()
		{
			// Arrange
			var expressionAnswer = ((1) + (2) - (3));
			var expression = "((1) + (2) - (3))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math25()
		{
			// Arrange
			var expressionAnswer = -(-(-1) + -(-2) - -(-3));
			var expression = "-(-(-1) + -(-2) - -(-3))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math26()
		{
			// Arrange
			var expressionAnswer = -(-(-(-1) + -(-2)) - -(-3));
			var expression = "-(-(-(-1) + -(-2)) - -(-3))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math27()
		{
			// Arrange
			var expressionAnswer = -(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3));
			var expression = "-(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Int 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void MathExpressionTests_Math28()
		{
			// Arrange
			float expressionAnswer = -(-(-(-1.25f * 2.5f + (3.75f / 3f) - 4.01f * 4.03f / (5.00f) % 6.0f) + -(-2.1234567890f)) - -(-3.000f));
			var expression = "-(-(-(-1.25 * 2.5 + (3.75 / 3) - 4.01 * 4.03 / (5.00) % 6.0) + -(-2.1234567890)) - -(-3.000))";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Float 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
