using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class EvaluatorTests
	{
		//[TestMethod]
		//public void EvaluatorTests_NoParenthesesStringOnLeft()
		//{
		//	// Arrange
		//	var answer = new ExpressionResult 
		//	{ 
		//		Value = "\"5example\"", 
		//		Type = VariableType.String 
		//	};

		//	var expression = "5 * 3 / 3 + \"example\"";

		//	var evaluator = new Evaluator();

		//	// Act
		//	var result = evaluator.Evaluate(expression);

		//	// Assert
		//	Assert.AreEqual(answer, result);


		//}

		//[TestMethod]
		//public void EvaluatorTests_SingleParenthesesForString()
		//{
		//	// Arrange
		//	var answer = new ExpressionResult { Value = "\"5example2\"", Type = VariableType.String };
		//	var exp = "5 * 3 / 3 + (\"example2\")";

		//	// Act
		//	var result = evaluator.Evaluate(exp);

		//	// Assert
		//	Assert.AreEqual(answer, result);
		//}

		//[TestMethod]
		//public void EvaluatorTests_ParenthesesForStringAddition()
		//{
		//	// Arrange
		//	var answer = new ExpressionResult { Value = "\"5example25\"", Type = VariableType.String }; ;
		//	var exp = "5 * 3 / 3 + (\"example2\" + 5)";

		//	// Act
		//	var result = evaluator.Evaluate(exp);

		//	// Assert
		//	Assert.AreEqual(answer, result);
		//}

		//[TestMethod]
		//public void EvaluatorTests_NestedParenthesesForString()
		//{
		//	// Arrange
		//	var answer = new ExpressionResult { Value = "\"5lol5\"", Type = VariableType.String }; ;
		//	var exp = "5 * 3 / 3 + ((\"lol\") + 5)";

		//	// Act
		//	var result = evaluator.Evaluate(exp);

		//	// Assert
		//	Assert.AreEqual(answer, result);
		//}

		//[TestMethod]
		//public void EvaluatorTests_NestedParenthesesForStringAddition()
		//{
		//	// Arrange
		//	var answer = new ExpressionResult { Value = "\"5example275\"", Type = VariableType.String }; ;
		//	var exp = "5 * 3 / 3 + ((\"example2\") + (5 * 15))";

		//	// Act
		//	var result = evaluator.Evaluate(exp);

		//	// Assert
		//	Assert.AreEqual(answer, result);
		//}

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
