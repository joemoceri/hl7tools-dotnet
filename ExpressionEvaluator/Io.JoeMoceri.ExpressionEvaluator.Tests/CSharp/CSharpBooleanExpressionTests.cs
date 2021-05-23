using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class CSharpBooleanExpressionTests
	{
		[TestMethod]
		public void BooleanExpressionTests_Boolean01()
		{
			// Arrange
			var expressionAnswer = 1 > 1;
			var expression = "1 > 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);
			
			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean02()
		{
			// Arrange
			var expressionAnswer = 1 > 2;
			var expression = "1 > 2";
			var answer = new ExpressionResult 
			{
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};
			 
			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean03()
		{
			// Arrange
			var expressionAnswer = 2 > 1;
			var expression = "2 > 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean04()
		{
			// Arrange
			var expressionAnswer = 1 >= 1;
			var expression = "1 >= 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean05()
		{
			// Arrange
			var expressionAnswer = 1 >= 2;
			var expression = "1 >= 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean06()
		{
			// Arrange
			var expressionAnswer = 2 >= 1;
			var expression = "2 >= 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean07()
		{
			// Arrange
			var expressionAnswer = 1 < 1;
			var expression = "1 < 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean08()
		{
			// Arrange
			var expressionAnswer = 1 < 2;
			var expression = "1 < 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean09()
		{
			// Arrange
			var expressionAnswer = 2 < 1;
			var expression = "2 < 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean10()
		{
			// Arrange
			var expressionAnswer = 1 <= 1;
			var expression = "1 <= 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean11()
		{
			// Arrange
			var expressionAnswer = 1 <= 2;
			var expression = "1 <= 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean12()
		{
			// Arrange
			var expressionAnswer = 2 <= 1;
			var expression = "2 <= 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean13()
		{
			// Arrange
			var expressionAnswer = 1 != 1;
			var expression = "1 != 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean14()
		{
			// Arrange
			var expressionAnswer = 1 != 2;
			var expression = "1 != 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean15()
		{
			// Arrange
			var expressionAnswer = 2 != 1;
			var expression = "2 != 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean16()
		{
			// Arrange
			var expressionAnswer = 1 == 1;
			var expression = "1 == 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean17()
		{
			// Arrange
			var expressionAnswer = 1 == 2;
			var expression = "1 == 2";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean18()
		{
			// Arrange
			var expressionAnswer = 2 == 1;
			var expression = "2 == 1";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean19()
		{
			// Arrange
			var expressionAnswer = true && true;
			var expression = "true && true";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean20()
		{
			// Arrange
			var expressionAnswer = true && false;
			var expression = "true && false";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean21()
		{
			// Arrange
			var expressionAnswer = false && true;
			var expression = "false && true";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean22()
		{
			// Arrange
			var expressionAnswer = false && false;
			var expression = "false && false";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean23()
		{
			// Arrange
			var expressionAnswer = true || true;
			var expression = "true || true";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean24()
		{
			// Arrange
			var expressionAnswer = true || false;
			var expression = "true || false";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean25()
		{
			// Arrange
			var expressionAnswer = false || true;
			var expression = "false || true";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean26()
		{
			// Arrange
			var expressionAnswer = false || false;
			var expression = "false || false";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean27()
		{
			// Arrange
			var expressionAnswer = 1 > 2 && true || false;
			var expression = "1 > 2 && true || false";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean28()
		{
			// Arrange
			var expressionAnswer = 1 > 2 && false || true;
			var expression = "1 > 2 && false || true";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean29()
		{
			// Arrange
			var expressionAnswer = 1 > 2 || false && true;
			var expression = "1 > 2 || false && true";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean30()
		{
			// Arrange
			var expressionAnswer = 1 > 2 || (false || true);
			var expression = "1 > 2 || (false || true)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean31()
		{
			// Arrange
			var expressionAnswer = 1 > 2 && (false || true);
			var expression = "1 > 2 && (false || true)";
			var answer = new ExpressionResult 
			{ 
				Value = expressionAnswer.ToString(), 
				Type = VariableType.Boolean 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanTrue()
		{
			// Arrange
			var expressionAnswer = true;
			var expression = "true";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanFalse()
		{
			// Arrange
			var expressionAnswer = false;
			var expression = "false";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanSingleParentheses()
		{
			// Arrange
			var expressionAnswer = (false);
			var expression = "(false)";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanDoubleParentheses()
		{
			// Arrange
			var expressionAnswer = ((false));
			var expression = "((false))";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard01()
		{
			// Arrange
			var expressionAnswer = 2 + 3 > 1 - 4 && 3 > 2;
			var expression = "2 + 3 > 1 - 4 && 3 > 2";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard02()
		{
			// Arrange
			var expressionAnswer = 1 > 2;
			var expression = "1 > 2";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard03()
		{
			// Arrange
			var expressionAnswer = (5 / 3) > 2;
			var expression = "(5 / 3) > 2";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard04()
		{
			// Arrange
			var expressionAnswer = -(-1 - -2) > -(-3 - -4);
			var expression = "-(-1 - -2) > -(-3 - -4)";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard05()
		{
			// Arrange
			var expressionAnswer = 2 > 1 == true;
			var expression = "2 > 1 == true";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void EvaluatorTests_BooleanStandard06()
		{
			// Arrange
			var expressionAnswer = 2 > 1 != true;
			var expression = "2 > 1 != true";
			var answer = new ExpressionResult
			{
				Value = expressionAnswer.ToString(),
				Type = VariableType.Boolean
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
