using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class CSharpBooleanExpressionTests
	{
		private Evaluator evaluator = new Evaluator();

		[TestMethod]
		public void BooleanExpressionTests_Boolean01()
		{
			// Arrange
			var ans = 1 > 1;
			var expression = "1 > 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);
			
			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean02()
		{
			// Arrange
			var ans = 1 > 2;
			var expression = "1 > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean03()
		{
			// Arrange
			var ans = 2 > 1;
			var expression = "2 > 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean04()
		{
			// Arrange
			var ans = 1 >= 1;
			var expression = "1 >= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean05()
		{
			// Arrange
			var ans = 1 >= 2;
			var expression = "1 >= 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean06()
		{
			// Arrange
			var ans = 2 >= 1;
			var expression = "2 >= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean07()
		{
			// Arrange
			var ans = 1 < 1;
			var expression = "1 < 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean08()
		{
			// Arrange
			var ans = 1 < 2;
			var expression = "1 < 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean09()
		{
			// Arrange
			var ans = 2 < 1;
			var expression = "2 < 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean10()
		{
			// Arrange
			var ans = 1 <= 1;
			var expression = "1 <= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean11()
		{
			// Arrange
			var ans = 1 <= 2;
			var expression = "1 <= 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean12()
		{
			// Arrange
			var ans = 2 <= 1;
			var expression = "2 <= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean13()
		{
			// Arrange
			var ans = 1 != 1;
			var expression = "1 != 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean14()
		{
			// Arrange
			var ans = 1 != 2;
			var expression = "1 != 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean15()
		{
			// Arrange
			var ans = 2 != 1;
			var expression = "2 != 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean16()
		{
			// Arrange
			var ans = 1 == 1;
			var expression = "1 == 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean17()
		{
			// Arrange
			var ans = 1 == 2;
			var expression = "1 == 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean18()
		{
			// Arrange
			var ans = 2 == 1;
			var expression = "2 == 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean19()
		{
			// Arrange
			var ans = true && true;
			var expression = "True && True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean20()
		{
			// Arrange
			var ans = true && false;
			var expression = "True && False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean21()
		{
			// Arrange
			var ans = false && true;
			var expression = "False && True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean22()
		{
			// Arrange
			var ans = false && false;
			var expression = "False && False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean23()
		{
			// Arrange
			var ans = true || true;
			var expression = "True || True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean24()
		{
			// Arrange
			var ans = true || false;
			var expression = "True || False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean25()
		{
			// Arrange
			var ans = false || true;
			var expression = "False || True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean26()
		{
			// Arrange
			var ans = false || false;
			var expression = "False || False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean27()
		{
			// Arrange
			var ans = 1 > 2 && true || false;
			var expression = "1 > 2 && True || False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean28()
		{
			// Arrange
			var ans = 1 > 2 && false || true;
			var expression = "1 > 2 && False || True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean29()
		{
			// Arrange
			var ans = 1 > 2 || false && true;
			var expression = "1 > 2 || False && True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean30()
		{
			// Arrange
			var ans = 1 > 2 || (false || true);
			var expression = "1 > 2 || (False || True)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void BooleanExpressionTests_Boolean31()
		{
			// Arrange
			var ans = 1 > 2 && (false || true);
			var expression = "1 > 2 && (False || True)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
