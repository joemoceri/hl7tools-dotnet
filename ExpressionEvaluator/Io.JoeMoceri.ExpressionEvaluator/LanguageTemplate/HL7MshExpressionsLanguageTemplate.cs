using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7MshExpressionsLanguageTemplate : LanguageTemplateBase
    {
        private readonly IList<LanguageTemplateOperator> operators;

        public HL7MshExpressionsLanguageTemplate()
        {
            operators = new List<LanguageTemplateOperator>
            {
                CreateLanguageTemplateOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "|")
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

        public override string Name => "HL7 MSH Expressions";

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
    }
}
