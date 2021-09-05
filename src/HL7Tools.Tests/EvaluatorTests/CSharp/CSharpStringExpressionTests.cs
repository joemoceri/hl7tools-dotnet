using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HL7Tools.Tests
{
	[TestClass]
	public class CSharpStringExpressionTests
	{
		public string EncloseInQuotes(string result)
        {
			return $"\"{result}\"";
        }

		[TestMethod]
		public void StringExpressionTests_ThreeOperandExpression()
		{
			// Arrange
			var expressionAnswer =  " ab + " + " cd " + 3;
			var expression = " \" ab + \" + \" cd \" + 3";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_LeftStringAddition()
		{
			// Arrange
			var expressionAnswer =  " ab + " + 3;
			var expression = " \" ab + \" + 3";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_LeftStringAddition2()
		{
			// Arrange
			var expressionAnswer =  " ab + " + 3 + "cd" + 4;
			var expression = " \" ab + \" + 3 + \"cd\" + 4";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_RightStringAddition()
		{
			// Arrange
			var expressionAnswer =  4 + " cd ";
			var expression = " 4 + \" cd \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_RightStringAddition2()
		{
			// Arrange
			var expressionAnswer = 3 + "ab" + 4 + " cd ";
			var expression = "3 + \"ab\" + 4 + \" cd \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_RightStringAddition_EscapedDoubleQuote()
		{
			// Arrange
			var expressionAnswer =  4 + " \\\"cd ";
			var expression = " 4 + \" \\\"cd \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_ParenthesesLeftAddition()
		{
			// Arrange
			var expressionAnswer =  4 + (" cd " + "lol");
			var expression = " 4 + (\" cd \" + \"lol\")";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_ParenthesesRightAddition()
		{
			// Arrange
			var expressionAnswer = (" cd " + "lol") + 4  ;
			var expression = "(\" cd \" + \"lol\") + 4  ";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParentheses()
		{
			// Arrange
			var expressionAnswer = (" cd " + ("lol")) + 4  ;
			var expression = "(\" cd \" + (\"lol\")) + 4  ";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesInsideLeftParentheses()
		{
			// Arrange
			var expressionAnswer = (" cd " + ("lol(")) + 4  ;
			var expression = "(\" cd \" + (\"lol(\")) + 4  ";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesInsideRightParentheses()
		{
			// Arrange
			var expressionAnswer = (" cd " + ("lol)")) + 4  ;
			var expression = "(\" cd \" + (\"lol)\")) + 4  ";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesInsideBothParentheses()
		{
			// Arrange
			var expressionAnswer = (" cd " + ("(lol)")) + 4  ;
			var expression = "(\" cd \" + (\"(lol)\")) + 4  ";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_NestedParenthesesExpression()
		{
			// Arrange
			var expressionAnswer = (" cd " + ("lol" + "lmao"));
			var expression = "(\" cd \" + (\"lol\" + \"lmao\"))";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer),
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(result, answer);
		}

		[TestMethod]
		public void StringExpressionTests_String01()
		{
			// Arrange
			var expressionAnswer = "test";
			var expression = "\"test\"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String02()
		{
			// Arrange
			var expressionAnswer = " test ";
			var expression = "\" test \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String03()
		{
			// Arrange
			var expressionAnswer = " \\\"test ";
			var expression = "\" \\\"test \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String04()
		{
			// Arrange
			var expressionAnswer = "test ";
			var expression = "\"test \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String05()
		{
			// Arrange
			var expressionAnswer = " test";
			var expression = "\" test\"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String06()
		{
			// Arrange
			var expressionAnswer = " test " + "test2";
			var expression = "\" test \" + \"test2\"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String07()
		{
			// Arrange
			var expressionAnswer = " test " + 1;
			var expression = "\" test \" + 1";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String08()
		{
			// Arrange
			var expressionAnswer = 1 + " test ";
			var expression = "1 + \" test \"";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String10()
		{
			// Arrange
			var expressionAnswer = " test " + 2;
			var expression = "\" test \" + 2";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String11()
		{
			// Arrange

			var expressionAnswer = " test " + 2 + 3;
			var expression = "\" test \" + 2 + 3";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String12()
		{
			// Arrange
			var expressionAnswer = 3 + " test " + 2;
			var expression = "3 + \" test \" + 2";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String13()
		{
			// Arrange
			var expressionAnswer = 3 + " test " + 2 + 3;
			var expression = "3 + \" test \" + 2 + 3";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String14()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + " test " + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + \" test \" + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String15()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + (" test ") + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + (\" test \") + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String16()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + (" test " + 6) + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + (\" test \" + 6) + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String17()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + (" test " + 6 + " ") + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + (\" test \" + 6 + \" \") + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String18()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + (" test " + 6 + " ") + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + (\" test \" + 6 + \" \") + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String19()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + (" test " + (6) + (" ")) + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + (\" test \" + (6) + (\" \")) + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String20()
		{
			// Arrange

			var expressionAnswer = ("test");
			var expression = "(\"test\")";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringExpressionTests_String21()
		{
			// Arrange
			var expressionAnswer = ( 3 + 4 ) + ((" test " + (6)) + ("test2")) + 2 + ( 3 + 5);
			var expression = "( 3 + 4 ) + ((\" test \" + (6)) + (\"test2\")) + 2 + ( 3 + 5)";
			var answer = new ExpressionResult 
			{ 
				Value = EncloseInQuotes(expressionAnswer), 
				Type = VariableType.String 
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);
		}
	}
}
