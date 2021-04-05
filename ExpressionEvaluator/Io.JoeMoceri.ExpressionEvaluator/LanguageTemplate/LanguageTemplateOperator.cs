using System;

namespace ExpressionEvaluator
{
    public class LanguageTemplateOperator
    {
        public Operator ExpressionOperator;
        public OperatorPrecedence ExpressionOperatorPrecedence;
        public string OperatorName;
        public Func<ExpressionGroup, ExpressionResult> CustomOperatorAction;
    }
}
