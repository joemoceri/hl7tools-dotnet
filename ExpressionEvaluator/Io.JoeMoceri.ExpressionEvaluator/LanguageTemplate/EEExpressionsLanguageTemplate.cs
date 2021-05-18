using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class EEExpressionsLanguageTemplate : LanguageTemplateBase
    {
        private readonly IList<LanguageTemplateOperator> operators;
        private readonly LanguageTemplateOptions options;

        public EEExpressionsLanguageTemplate()
        {
            operators = new List<LanguageTemplateOperator>
            {
                CreateLanguageTemplateOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "+"),
                CreateLanguageTemplateOperator(Operator.Subtraction, OperatorPrecedence.Lower, OperatorType.MathString, "-"),
                CreateLanguageTemplateOperator(Operator.Multiplication, OperatorPrecedence.Higher, OperatorType.MathString, "*"),
                CreateLanguageTemplateOperator(Operator.Division, OperatorPrecedence.Higher, OperatorType.MathString, "/"),
                CreateLanguageTemplateOperator(Operator.Modulus, OperatorPrecedence.Higher, OperatorType.MathString, "%"),
                CreateLanguageTemplateOperator(Operator.And, OperatorPrecedence.Lower, OperatorType.Boolean, "and"),
                CreateLanguageTemplateOperator(Operator.And, OperatorPrecedence.Lower, OperatorType.Boolean, "&&"),
                CreateLanguageTemplateOperator(Operator.Or, OperatorPrecedence.Lower, OperatorType.Boolean, "||"),
                CreateLanguageTemplateOperator(Operator.Or, OperatorPrecedence.Lower, OperatorType.Boolean, "or"),
                CreateLanguageTemplateOperator(Operator.LessThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "<="),
                CreateLanguageTemplateOperator(Operator.GreaterThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, ">="),
                CreateLanguageTemplateOperator(Operator.EqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "=="),
                CreateLanguageTemplateOperator(Operator.NotEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "!="),
                CreateLanguageTemplateOperator(Operator.LessThan, OperatorPrecedence.Higher, OperatorType.Boolean, "<"),
                CreateLanguageTemplateOperator(Operator.GreaterThan, OperatorPrecedence.Higher, OperatorType.Boolean, ">"),
            };

            options = new LanguageTemplateOptions
            {
                IgnoreWhitespaceOutsideQuotes = false,
                IgnoreParentheses = false
            };
        }

        private LanguageTemplateOperator CreateLanguageTemplateOperator(
            Operator expressionOperator, 
            OperatorPrecedence operatorPrecedence, 
            OperatorType expressionOperatorType,
            string operatorName, 
            Func<ExpressionGroup, ExpressionResult> solveOperatorExpression = null,
            Action<ExpressionGroup> onBeforeOperatorExpressionSolved = null,
            Action<ExpressionResult> onAfterOperatorExpressionSolved = null)
        {
            return new LanguageTemplateOperator
            {
                ExpressionOperator = expressionOperator,
                ExpressionOperatorPrecedence = operatorPrecedence,
                ExpressionOperatorType = expressionOperatorType,
                OperatorName = operatorName,
                SolveOperatorExpression = solveOperatorExpression,
                OnBeforeOperatorExpressionSolved = onBeforeOperatorExpressionSolved,
                OnAfterOperatorExpressionSolved = onAfterOperatorExpressionSolved
            };
        }

        public override string Name => "EE Expressions";

        public override IList<LanguageTemplateOperator> MathStringOperators 
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        public override IList<LanguageTemplateOperator> BooleanOperators
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        public override IList<LanguageTemplateOperator> Operators => operators;

        public override LanguageTemplateOptions Options => options;
    }
}
