using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class CSharpExpressionConfiguration : ExpressionConfigurationBase
    {
        private readonly IList<ExpressionConfigurationOperator> operators;
        private readonly ExpressionConfigurationOptions options;

        public CSharpExpressionConfiguration()
        {
            operators = new List<ExpressionConfigurationOperator>
            {
                CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "+"),
                CreateExpressionConfigurationOperator(Operator.Subtraction, OperatorPrecedence.Lower, OperatorType.MathString, "-"),
                CreateExpressionConfigurationOperator(Operator.Multiplication, OperatorPrecedence.Higher, OperatorType.MathString, "*"),
                CreateExpressionConfigurationOperator(Operator.Division, OperatorPrecedence.Higher, OperatorType.MathString, "/"),
                CreateExpressionConfigurationOperator(Operator.Modulus, OperatorPrecedence.Higher, OperatorType.MathString, "%"),
                CreateExpressionConfigurationOperator(Operator.And, OperatorPrecedence.Lower, OperatorType.Boolean, "&&"),
                CreateExpressionConfigurationOperator(Operator.Or, OperatorPrecedence.Lower, OperatorType.Boolean, "||"),
                CreateExpressionConfigurationOperator(Operator.LessThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "<="),
                CreateExpressionConfigurationOperator(Operator.GreaterThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, ">="),
                CreateExpressionConfigurationOperator(Operator.EqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "=="),
                CreateExpressionConfigurationOperator(Operator.NotEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "!="),
                CreateExpressionConfigurationOperator(Operator.LessThan, OperatorPrecedence.Higher, OperatorType.Boolean, "<"),
                CreateExpressionConfigurationOperator(Operator.GreaterThan, OperatorPrecedence.Higher, OperatorType.Boolean, ">"),
            };

            options = new ExpressionConfigurationOptions
            {
                IgnoreWhitespaceOutsideQuotes = false,
                IgnoreParentheses = false,
                IgnoreQuotesValidation = false
            };
        }

        public override IList<ExpressionConfigurationOperator> Operators => operators;

        public override ExpressionConfigurationOptions Options => options;
    }
}
