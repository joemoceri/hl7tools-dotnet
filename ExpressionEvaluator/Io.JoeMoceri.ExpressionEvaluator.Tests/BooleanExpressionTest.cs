using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class BooleanExpressionTest
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void Boolean01()
		{
			// Arrange
			var ans = 1 > 1;
			var expression = "1 > 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);
			
			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean02()
		{
			// Arrange
			var ans = 1 > 2;
			var expression = "1 > 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean03()
		{
			// Arrange
			var ans = 2 > 1;
			var expression = "2 > 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean04()
		{
			// Arrange
			var ans = 1 >= 1;
			var expression = "1 >= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean05()
		{
			// Arrange
			var ans = 1 >= 2;
			var expression = "1 >= 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean06()
		{
			// Arrange
			var ans = 2 >= 1;
			var expression = "2 >= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean07()
		{
			// Arrange
			var ans = 1 < 1;
			var expression = "1 < 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean08()
		{
			// Arrange
			var ans = 1 < 2;
			var expression = "1 < 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean09()
		{
			// Arrange
			var ans = 2 < 1;
			var expression = "2 < 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean10()
		{
			// Arrange
			var ans = 1 <= 1;
			var expression = "1 <= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean11()
		{
			// Arrange
			var ans = 1 <= 2;
			var expression = "1 <= 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean12()
		{
			// Arrange
			var ans = 2 <= 1;
			var expression = "2 <= 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean13()
		{
			// Arrange
			var ans = 1 != 1;
			var expression = "1 != 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean14()
		{
			// Arrange
			var ans = 1 != 2;
			var expression = "1 != 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean15()
		{
			// Arrange
			var ans = 2 != 1;
			var expression = "2 != 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean16()
		{
			// Arrange
			var ans = 1 == 1;
			var expression = "1 == 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean17()
		{
			// Arrange
			var ans = 1 == 2;
			var expression = "1 == 2";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean18()
		{
			// Arrange
			var ans = 2 == 1;
			var expression = "2 == 1";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean19()
		{
			// Arrange
			var ans = true && true;
			var expression = "True && True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean20()
		{
			// Arrange
			var ans = true && false;
			var expression = "True && False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean21()
		{
			// Arrange
			var ans = false && true;
			var expression = "False && True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean22()
		{
			// Arrange
			var ans = false && false;
			var expression = "False && False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean23()
		{
			// Arrange
			var ans = true || true;
			var expression = "True || True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean24()
		{
			// Arrange
			var ans = true || false;
			var expression = "True || False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean25()
		{
			// Arrange
			var ans = false || true;
			var expression = "False || True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean26()
		{
			// Arrange
			var ans = false || false;
			var expression = "False || False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean27()
		{
			// Arrange
			var ans = 1 > 2 && true || false;
			var expression = "1 > 2 && True || False";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean28()
		{
			// Arrange
			var ans = 1 > 2 && false || true;
			var expression = "1 > 2 && False || True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean29()
		{
			// Arrange
			var ans = 1 > 2 || false && true;
			var expression = "1 > 2 || False && True";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean30()
		{
			// Arrange
			var ans = 1 > 2 || (false || true);
			var expression = "1 > 2 || (False || True)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void Boolean31()
		{
			// Arrange
			var ans = 1 > 2 && (false || true);
			var expression = "1 > 2 && (False || True)";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VariableType.Boolean };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
