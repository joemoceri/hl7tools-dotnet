using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// This is the default expression configuration used by the <see cref="Evaluator"/>. It has settings for evaluating math, string, and boolean expressions relative to C# syntax.
    /// </summary>
    public class CSharpExpressionConfiguration : ExpressionConfigurationBase
    {
        /// <summary>
        /// A list of <see cref="ExpressionConfigurationOperator"/> used by the expression configuration.
        /// </summary>
        private readonly IList<ExpressionConfigurationOperator> operators;

        /// <summary>
        /// The options used by the expression configuration.
        /// </summary>
        private readonly ExpressionConfigurationOptions options;

        /// <summary>
        /// This constructor initializes the operators and options for the expression configuration.
        /// </summary>
        public CSharpExpressionConfiguration()
        {
            operators = new List<ExpressionConfigurationOperator>
            {
                CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "+", null, null, null),
                CreateExpressionConfigurationOperator(Operator.Subtraction, OperatorPrecedence.Lower, OperatorType.MathString, "-", null, null, null),
                CreateExpressionConfigurationOperator(Operator.Multiplication, OperatorPrecedence.Higher, OperatorType.MathString, "*", null, null, null),
                CreateExpressionConfigurationOperator(Operator.Division, OperatorPrecedence.Higher, OperatorType.MathString, "/", null, null, null),
                CreateExpressionConfigurationOperator(Operator.Modulus, OperatorPrecedence.Higher, OperatorType.MathString, "%", null, null, null),
                CreateExpressionConfigurationOperator(Operator.And, OperatorPrecedence.Lower, OperatorType.Boolean, "&&", null, null, null),
                CreateExpressionConfigurationOperator(Operator.Or, OperatorPrecedence.Lower, OperatorType.Boolean, "||", null, null, null),
                CreateExpressionConfigurationOperator(Operator.LessThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "<=", null, null, null),
                CreateExpressionConfigurationOperator(Operator.GreaterThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, ">=", null, null, null),
                CreateExpressionConfigurationOperator(Operator.EqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "==", null, null, null),
                CreateExpressionConfigurationOperator(Operator.NotEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "!=", null, null, null),
                CreateExpressionConfigurationOperator(Operator.LessThan, OperatorPrecedence.Higher, OperatorType.Boolean, "<", null, null, null),
                CreateExpressionConfigurationOperator(Operator.GreaterThan, OperatorPrecedence.Higher, OperatorType.Boolean, ">", null, null, null),
            };

            options = new ExpressionConfigurationOptions
            {
                IgnoreWhitespaceOutsideQuotes = false,
                IgnoreParentheses = false,
                IgnoreQuotesValidation = false
            };
        }

        /// <summary>
        /// A list of <see cref="ExpressionConfigurationOperator"/> used by the expression configuration.
        /// </summary>
        public override IList<ExpressionConfigurationOperator> Operators => operators;

        /// <summary>
        /// The options used by the expression configuration.
        /// </summary>
        public override ExpressionConfigurationOptions Options => options;
    }
}
