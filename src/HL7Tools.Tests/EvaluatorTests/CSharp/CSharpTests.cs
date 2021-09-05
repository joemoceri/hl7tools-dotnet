using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HL7Tools.Tests.EvaluatorTests.CSharp
{
    [TestClass]
    public class CSharpTests
    {
        [TestMethod]
        public void CSharpTests_CSharpExpressionConfiguration()
        {
            var expConfig = new CSharpExpressionConfiguration();

			Assert.AreEqual(expConfig.Operators.Count, 13);

			Assert.AreEqual(expConfig.MathStringOperators.Count, 5);

			Assert.AreEqual(expConfig.BooleanOperators.Count, 8);

			Assert.AreEqual(expConfig.Options.IgnoreParentheses, false);

			Assert.AreEqual(expConfig.Options.IgnoreWhitespaceOutsideQuotes, false);

			Assert.AreEqual(expConfig.Options.IgnoreQuotesValidation, false);

			Assert.AreEqual(expConfig.Operators[0].ExpressionOperator, Operator.Addition);
			Assert.AreEqual(expConfig.Operators[0].OperatorName, "+");
			Assert.AreEqual(expConfig.Operators[0].ExpressionOperatorPrecedence, OperatorPrecedence.Lower);
			Assert.AreEqual(expConfig.Operators[0].ExpressionOperatorType, OperatorType.MathString);
			Assert.AreEqual(expConfig.Operators[0].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[1].ExpressionOperator, Operator.Subtraction);
			Assert.AreEqual(expConfig.Operators[1].OperatorName, "-");
			Assert.AreEqual(expConfig.Operators[1].ExpressionOperatorPrecedence, OperatorPrecedence.Lower);
			Assert.AreEqual(expConfig.Operators[1].ExpressionOperatorType, OperatorType.MathString);
			Assert.AreEqual(expConfig.Operators[1].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[2].ExpressionOperator, Operator.Multiplication);
			Assert.AreEqual(expConfig.Operators[2].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[2].ExpressionOperatorType, OperatorType.MathString);
			Assert.AreEqual(expConfig.Operators[2].OperatorName, "*");
			Assert.AreEqual(expConfig.Operators[2].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[3].ExpressionOperator, Operator.Division);
			Assert.AreEqual(expConfig.Operators[3].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[3].ExpressionOperatorType, OperatorType.MathString);
			Assert.AreEqual(expConfig.Operators[3].OperatorName, "/");
			Assert.AreEqual(expConfig.Operators[3].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[4].ExpressionOperator, Operator.Modulus);
			Assert.AreEqual(expConfig.Operators[4].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[4].ExpressionOperatorType, OperatorType.MathString);
			Assert.AreEqual(expConfig.Operators[4].OperatorName, "%");
			Assert.AreEqual(expConfig.Operators[4].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[5].ExpressionOperator, Operator.And);
			Assert.AreEqual(expConfig.Operators[5].ExpressionOperatorPrecedence, OperatorPrecedence.Lower);
			Assert.AreEqual(expConfig.Operators[5].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[5].OperatorName, "&&");
			Assert.AreEqual(expConfig.Operators[5].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[6].ExpressionOperator, Operator.Or);
			Assert.AreEqual(expConfig.Operators[6].ExpressionOperatorPrecedence, OperatorPrecedence.Lower);
			Assert.AreEqual(expConfig.Operators[6].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[6].OperatorName, "||");
			Assert.AreEqual(expConfig.Operators[6].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[7].ExpressionOperator, Operator.LessThanOrEqualTo);
			Assert.AreEqual(expConfig.Operators[7].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[7].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[7].OperatorName, "<=");
			Assert.AreEqual(expConfig.Operators[7].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[8].ExpressionOperator, Operator.GreaterThanOrEqualTo);
			Assert.AreEqual(expConfig.Operators[8].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[8].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[8].OperatorName, ">=");
			Assert.AreEqual(expConfig.Operators[8].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[9].ExpressionOperator, Operator.EqualTo);
			Assert.AreEqual(expConfig.Operators[9].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[9].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[9].OperatorName, "==");
			Assert.AreEqual(expConfig.Operators[9].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[10].ExpressionOperator, Operator.NotEqualTo);
			Assert.AreEqual(expConfig.Operators[10].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[10].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[10].OperatorName, "!=");
			Assert.AreEqual(expConfig.Operators[10].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[11].ExpressionOperator, Operator.LessThan);
			Assert.AreEqual(expConfig.Operators[11].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[11].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[11].OperatorName, "<");
			Assert.AreEqual(expConfig.Operators[11].SolveOperatorExpression, null);

			Assert.AreEqual(expConfig.Operators[12].ExpressionOperator, Operator.GreaterThan);
			Assert.AreEqual(expConfig.Operators[12].ExpressionOperatorPrecedence, OperatorPrecedence.Higher);
			Assert.AreEqual(expConfig.Operators[12].ExpressionOperatorType, OperatorType.Boolean);
			Assert.AreEqual(expConfig.Operators[12].OperatorName, ">");
			Assert.AreEqual(expConfig.Operators[12].SolveOperatorExpression, null);
		}
    }
}
