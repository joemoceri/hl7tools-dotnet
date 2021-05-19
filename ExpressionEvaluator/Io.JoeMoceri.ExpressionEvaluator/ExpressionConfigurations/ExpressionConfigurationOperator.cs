using System;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class ExpressionConfigurationOperator
    {
        public Operator ExpressionOperator;
        public OperatorPrecedence ExpressionOperatorPrecedence;
        public OperatorType ExpressionOperatorType;
        public string OperatorName;
        /// <summary>
        /// Called before the next operator expression is solved
        /// </summary>
        public Action<ExpressionGroup> OnBeforeOperatorExpressionSolved;
        public Action<ExpressionResult> OnAfterOperatorExpressionSolved;
        public Func<ExpressionGroup, ExpressionResult> SolveOperatorExpression;
    }
}
