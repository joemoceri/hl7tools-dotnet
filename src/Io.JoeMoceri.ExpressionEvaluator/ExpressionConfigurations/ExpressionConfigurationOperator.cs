using System;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    /// <summary>
    /// 
    /// </summary>
    public class ExpressionConfigurationOperator
    {
        /// <summary>
        /// 
        /// </summary>
        public Operator ExpressionOperator;
        /// <summary>
        /// 
        /// </summary>
        public OperatorPrecedence ExpressionOperatorPrecedence;
        /// <summary>
        /// 
        /// </summary>
        public OperatorType ExpressionOperatorType;
        /// <summary>
        /// 
        /// </summary>
        public string OperatorName;
        /// <summary>
        /// Called before the next operator expression is solved
        /// </summary>
        public Action<ExpressionGroup> OnBeforeOperatorExpressionSolved;
        /// <summary>
        /// 
        /// </summary>
        public Action<ExpressionResult> OnAfterOperatorExpressionSolved;
        /// <summary>
        /// 
        /// </summary>
        public Func<ExpressionGroup, ExpressionResult> SolveOperatorExpression;
    }
}
