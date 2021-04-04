using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpressionEvaluator.Tests
{
	/// <summary>
	/// Summary description for StringArithmetic_Test_NonExpressionTests
	/// </summary>
	[TestClass]
	public class StringArithmeticTest_NonExpressionTests
	{
		[TestMethod]
		public void StringArithmetic_RemoveWhitespaceOutsideQuotes_DoubleQuotes()
		{
			// Arrange
			var result = " \" ab \" + \" cd \"*\"5\"*5";
			var answer = "\" ab \"+\" cd \"*\"5\"*5";

			// Act
			//result = result.RemoveWhitespaceOutsideQuotes();

			// Assert
			//Assert.AreEqual(answer, result);
		}

		[TestMethod]
		public void StringArithmetic_FindFirstSelectionOutsideQuotes_HigherPrecedence()
		{
			// Arrange
			var check = " \" ab \" + \" cd \"*\"5\"*5";

			// Act
			var result = check.IndexOfOutsideQuotes('*');

			// Assert
			Assert.AreEqual(result, 16);
		}

		[TestMethod]
		public void StringArithmetic_FindFirstSelectionOutsideQuotes_HigherPrecedence_InsideQuotes()
		{
			// Arrange
			var check = " \" ab * \" + \" cd \"*\"5\"*5";

			// Act
			var result = check.IndexOfOutsideQuotes('*');

			// Assert
			Assert.AreEqual(result, 18);
		}

		[TestMethod]
		public void StringArithmetic_FindFirstSelectionOutsideQuotes_LowerPrecedence()
		{
			// Arrange
			var check = " \" ab \" + \" cd \"*\"5\"*5";

			// Act
			var result = check.IndexOfOutsideQuotes('+');

			// Assert
			Assert.AreEqual(result, 8);
		}

		[TestMethod]
		public void StringArithmetic_FindFirstSelectionOutsideQuotes_LowerPrecedence_InsideQuotes()
		{
			// Arrange
			var check = " \" ab + \" + \" cd \"*\"5\"*5";

			// Act
			var result = check.IndexOfOutsideQuotes('+');

			// Assert
			Assert.AreEqual(result, 10);
		}

		//[TestMethod]
		//public void StringArithmetic_GetLeftOperand()
		//{
		//	// Arrange
		//	var check = " \" ab + \" + \" cd \"";
		//	check = check.RemoveWhitespaceOutsideQuotes();
		//	// Act
		//	var result = solver.GetLeftMathOperand(check, check.IndexOfOutsideQuotes('+'));

		//	// Assert
		//	Assert.AreEqual(result, "\" ab + \"");
		//}

		//[TestMethod]
		//public void StringArithmetic_GetRightOperand()
		//{
		//	// Arrange
		//	var check = " \" ab + \" + \" cd \"";
		//	check = check.RemoveWhitespaceOutsideQuotes();
		//	// Act
		//	var result = solver.GetRightMathOperand(check, check.IndexOfOutsideQuotes('+'));

		//	// Assert
		//	Assert.AreEqual(result, "\" cd \"");
		//}


	}
}
