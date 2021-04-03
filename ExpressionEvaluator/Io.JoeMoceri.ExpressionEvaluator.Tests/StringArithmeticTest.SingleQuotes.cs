using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	[TestClass]
	public class StringArithmeticTest_SingleQuotes
	{

		//[TestMethod]
		//public void StringArithmetic_AddDifferentQuotedStrings()
		//{
		//	// Arrange
		//	var check = " \"42'\" + ' ()()cd '";

		//	// Act
		//	var result = new StringArithmetic().Solve(check);

		//	// Assert
		//	Assert.AreEqual(result, "42' ()()cd ");
		//}

		//[TestMethod]
		//public void StringArithmetic_AddDifferentQuotedStrings_ReverseQuotes()
		//{
		//	// Arrange
		//	var check = " '42\"' + \" ()()cd \"";

		//	// Act
		//	var result = new StringArithmetic().Solve(check);

		//	// Assert
		//	Assert.AreEqual(result, "42\" ()()cd ");
		//}

		//[TestMethod]
		//public void StringArithmetic_AddDifferentQuotedStrings_Three()
		//{
		//	// Arrange
		//	var check = " '42\"' + \" ()()cd \" + '43'";

		//	// Act
		//	var result = new StringArithmetic().Solve(check);

		//	// Assert
		//	Assert.AreEqual(result, "42\" ()()cd 43");
		//}

		//[TestMethod]
		//public void StringArithmetic_GetCharCount_SameLevel_DifferentQuotes_SingleQuote()
		//{
		//	// Arrange
		//	var check = " '42\"' + '44' + \" ()()cd \"";

		//	// Act
		//	var result = GetCharCount(check, '\'');

		//	// Assert
		//	Assert.AreEqual(result, 4);
		//}

		//[TestMethod]
		//public void StringArithmetic_GetCharCount_ParenthesesInside_SingleQuote()
		//{
		//	// Arrange
		//	var check = " 4 * ' ()()cd '";

		//	// Act
		//	var result = GetCharCount(check, '(') + GetCharCount(check, ')');

		//	// Assert
		//	Assert.AreEqual(result, 0);
		//}

		//[TestMethod]
		//public void StringArithmetic_GetCharCount_SingleQuoteInside_SingleQuote()
		//{
		//	// Arrange
		//	var check = " 4 * ' \\'cd '";

		//	// Act
		//	var result = GetCharCount(check, '\'');

		//	// Assert
		//	Assert.AreEqual(result, 2);
		//}

		//[TestMethod]
		//public void StringArithmetic_GetCharCount_DoubleQuoteInside_SingleQuote()
		//{
		//	// Arrange
		//	var check = " 4 * ' \"cd '";

		//	// Act
		//	var result = GetCharCount(check, '\'');

		//	// Assert
		//	Assert.AreEqual(result, 2);
		//}

		//[TestMethod]
		//public void StringArithmetic_RemoveWhitespaceOutsideQuotes_SingleQuotes()
		//{
		//	// Arrange
		//	var result = " ' ab ' + ' cd '*'5'";
		//	var answer = "' ab '+' cd '*'5'";

		//	// Act
		//	result = result.RemoveWhitespaceOutsideQuotes();

		//	// Assert
		//	Assert.AreEqual(answer, result);
		//}

		//[TestMethod]
		//public void StringArithmetic_RemoveWhitespaceOutsideQuotes_MixQuotes()
		//{
		//	// Arrange
		//	var result = " ' ab ' + \" cd \"";
		//	var answer = "' ab '+\" cd \"";

		//	// Act
		//	result = result.RemoveWhitespaceOutsideQuotes();

		//	// Assert
		//	Assert.AreEqual(answer, result);
		//}

		//[TestMethod]
		//public void StringArithmetic_GetCharCount_SameLevel_DifferentQuotes_DoubleQuote()
		//{
		//	// Arrange
		//	var check = " '42\"' + \" ()()cd \" + \"43\"";

		//	// Act
		//	var result = GetCharCount(check, '"');

		//	// Assert
		//	Assert.AreEqual(result, 4);
		//}
	}
}
