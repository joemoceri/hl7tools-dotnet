using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Io.JoeMoceri.ExpressionEvaluator.Tests
{
	[TestClass]
	public class CSharpExpressionTests
	{
		[TestMethod]
        #region Boolean test cases
        [DataRow(1 > 1, "1 > 1", VariableType.Boolean)]
		[DataRow(1 > 2, "1 > 2", VariableType.Boolean)]
		[DataRow(2 > 1, "2 > 1", VariableType.Boolean)]
		[DataRow(1 < 1, "1 < 1", VariableType.Boolean)]
		[DataRow(1 < 2, "1 < 2", VariableType.Boolean)]
		[DataRow(2 < 1, "2 < 1", VariableType.Boolean)]
		[DataRow(1 >= 1, "1 >= 1", VariableType.Boolean)]
		[DataRow(1 >= 2, "1 >= 2", VariableType.Boolean)]
		[DataRow(2 >= 1, "2 >= 1", VariableType.Boolean)]
		[DataRow(1 <= 1, "1 <= 1", VariableType.Boolean)]
		[DataRow(1 <= 2, "1 <= 2", VariableType.Boolean)]
		[DataRow(2 <= 1, "2 <= 1", VariableType.Boolean)]
		[DataRow(1 != 1, "1 != 1", VariableType.Boolean)]
		[DataRow(1 != 2, "1 != 2", VariableType.Boolean)]
		[DataRow(2 != 1, "2 != 1", VariableType.Boolean)]
		[DataRow(1 == 1, "1 == 1", VariableType.Boolean)]
		[DataRow(1 == 2, "1 == 2", VariableType.Boolean)]
		[DataRow(2 == 1, "2 == 1", VariableType.Boolean)]
		[DataRow(true && true, "true && true", VariableType.Boolean)]
		[DataRow(true || true, "true || true", VariableType.Boolean)]
		[DataRow(true && false, "true && false", VariableType.Boolean)]
		[DataRow(false && true, "false && true", VariableType.Boolean)]
		[DataRow(true || false, "true || false", VariableType.Boolean)]
		[DataRow(false || true, "false || true", VariableType.Boolean)]
		[DataRow(false && false, "false && false", VariableType.Boolean)]
		[DataRow(false || false, "false || false", VariableType.Boolean)]
		[DataRow(1 > 2 && true || false, "1 > 2 && true || false", VariableType.Boolean)]
		[DataRow(1 > 2 && false || true, "1 > 2 && false || true", VariableType.Boolean)]
		[DataRow(1 > 2 || false && true, "1 > 2 || false && true", VariableType.Boolean)]
		[DataRow(1 > 2 || (false || true), "1 > 2 || (false || true)", VariableType.Boolean)]
		[DataRow(1 > 2 && (false || true), "1 > 2 && (false || true)", VariableType.Boolean)]
		[DataRow(true, "true", VariableType.Boolean)]
		[DataRow(false, "false", VariableType.Boolean)]
		[DataRow((false), "(false)", VariableType.Boolean)]
		[DataRow(((false)), "((false))", VariableType.Boolean)]
		[DataRow(2 + 3 > 1 - 4 && 3 > 2, "2 + 3 > 1 - 4 && 3 > 2", VariableType.Boolean)]
		[DataRow((5 / 3) > 2, "(5 / 3) > 2", VariableType.Boolean)]
		[DataRow(-(-1 - -2) > -(-3 - -4), "-(-1 - -2) > -(-3 - -4)", VariableType.Boolean)]
		[DataRow(2 > 1 == true, "2 > 1 == true", VariableType.Boolean)]
		[DataRow(2 > 1 != true, "2 > 1 != true", VariableType.Boolean)]
		#endregion
		#region Math test cases
		[DataRow(4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5, "4.563 + 12 * 3 * 4 + 3 / 3 - 4 * 2 + 3 + 12 % 5", VariableType.Float)]
		[DataRow(-4.563 + -12 * -3 * -4 + -3 / -3 - -4 * -2 + -3 + -12 % -5, "-4.563 + -12 * -3 * -4 + -3 / -3 - -4 * -2 + -3 + -12 % -5", VariableType.Float)]
		[DataRow((((((4) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3)), "(((((4) + 12) * 3) * 4) + ((3) / 3) - (4 * 2 + 3))", VariableType.Int)]
		[DataRow((((((-4) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3)), "(((((-4) + -12) * -3) * -4) + ((-3) / -3) - (-4 * -2 + -3))", VariableType.Int)]
		[DataRow((((5 + 3))), "(((5 + 3)))", VariableType.Int)]
		[DataRow(-(-(-(5 + 3))), "-(-(-(5 + 3)))", VariableType.Int)]
		[DataRow(-(5 + 3), "-(5 + 3)", VariableType.Int)]
		[DataRow(4 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3), "4 + 12 - 3 * (4 + 3) / 3 - (4 * 2 + 3)", VariableType.Int)]
		[DataRow(-4 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3), "-4 + -12 - -3 * (-4 + -3) / -3 - -(-4 * -2 + -3)", VariableType.Int)]
		[DataRow(-3 - -(-4 * -2 + -3), "-3 - -(-4 * -2 + -3)", VariableType.Int)]
		[DataRow(-4 + -12 - -3 * -(-4 + -3), "-4 + -12 - -3 * -(-4 + -3)", VariableType.Int)]
		[DataRow(3 + -3, "3 + -3", VariableType.Int)]
		[DataRow(3 + -3 + 4, "3 + -3 + 4", VariableType.Int)]
		[DataRow(-3 + 3 + 4, "-3 + 3 + 4", VariableType.Int)]
		[DataRow(10, "10", VariableType.Int)]
		[DataRow(-5 - -10, "-5 - -10", VariableType.Int)]
		[DataRow(1 + 2, "1 + 2", VariableType.Int)]
		[DataRow(1 + 2 - 3, "1 + 2 - 3", VariableType.Int)]
		[DataRow(1 + 2 * 3, "1 + 2 * 3", VariableType.Int)]
		[DataRow(1 * 2 + 3, "1 * 2 + 3", VariableType.Int)]
		[DataRow(1 * 2 * 3, "1 * 2 * 3", VariableType.Int)]
		[DataRow(1 - 2, "1 - 2", VariableType.Int)]
		[DataRow(1 * 2, "1 * 2", VariableType.Int)]
		[DataRow(1 / 2, "1 / 2", VariableType.Int)]
		[DataRow(1 % 2, "1 % 2", VariableType.Int)]
		[DataRow(1, "1", VariableType.Int)]
		[DataRow(-1, "-1", VariableType.Int)]
		[DataRow(-1 + -2, "-1 + -2", VariableType.Int)]
		[DataRow(-1 - -2, "-1 - -2", VariableType.Int)]
		[DataRow(-1 * -2, "-1 * -2", VariableType.Int)]
		[DataRow(-1 % -2, "-1 % -2", VariableType.Int)]
		[DataRow(-1 / -2, "-1 / -2", VariableType.Int)]
		[DataRow(-1 + -2 * -3, "-1 + -2 * -3", VariableType.Int)]
		[DataRow(-1 * -2 + -3, "-1 * -2 + -3", VariableType.Int)]
		[DataRow(-1 - -2 - -3, "-1 - -2 - -3", VariableType.Int)]
		[DataRow((1), "(1)", VariableType.Int)]
		[DataRow((-1), "(-1)", VariableType.Int)]
		[DataRow((1 + 2), "(1 + 2)", VariableType.Int)]
		[DataRow((1 + 2 - 3), "(1 + 2 - 3)", VariableType.Int)]
		[DataRow(((1) + (2) - (3)), "((1) + (2) - (3))", VariableType.Int)]
		[DataRow(-(-(-1) + -(-2) - -(-3)), "-(-(-1) + -(-2) - -(-3))", VariableType.Int)]
		[DataRow(-(-(-(-1) + -(-2)) - -(-3)), "-(-(-(-1) + -(-2)) - -(-3))", VariableType.Int)]
		[DataRow(-(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3)), "-(-(-(-1 * 2 + (3 / 3) - 4 * 4 / (5) % 6) + -(-2)) - -(-3))", VariableType.Int)]
		[DataRow(-(-(-(-1.25f * 2.5f + (3.75f / 3f) - 4.01f * 4.03f / (5.00f) % 6.0f) + -(-2.1234567890f)) - -(-3.000f)), "-(-(-(-1.25 * 2.5 + (3.75 / 3) - 4.01 * 4.03 / (5.00) % 6.0) + -(-2.1234567890)) - -(-3.000))", VariableType.Float)]
		#endregion
		#region String test cases
		[DataRow(" ab + ", " ab + ", VariableType.String)]
		[DataRow(" ab + " + " cd ", " ab + " + " cd ", VariableType.String)]
		[DataRow(" ab + " + " cd " + " ef ", " ab + " + " cd " + " ef ", VariableType.String)]
		#endregion
		public void ExpressionTests(object expressionAnswer, string expression, VariableType variableType)
		{
			// Arrange
			var value = expressionAnswer.ToString();

			if (variableType == VariableType.String)
            {
				expression = EncloseInQuotes(expression);
				value = EncloseInQuotes(value);
            }

			var answer = new ExpressionResult 
			{ 
				Value = value,
				Type = variableType
			};

			var evaluator = new Evaluator();

			// Act
			var result = evaluator.Evaluate(expression);

			// Assert
			Assert.AreEqual(answer, result);

			string EncloseInQuotes(string result)
			{
				return $"\"{result}\"";
			}
		}
	}
}
