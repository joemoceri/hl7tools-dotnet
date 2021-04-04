using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class StringExpressionTest
	{
		private Evaluator solver = new Evaluator();

		[TestMethod]
		public void String01()
		{
			// Arrange
			var ans = "\"test\"";
			var expression = "\"test\"";
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

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
			var answer = new ExpressionResult { Value = ans.ToString(), Type = VarType.String };

			// Act
			var result = solver.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

	}
}
