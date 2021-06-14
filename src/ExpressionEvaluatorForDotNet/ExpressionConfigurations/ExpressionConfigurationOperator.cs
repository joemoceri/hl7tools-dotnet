using System;

namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// This class represents an operator to an <see cref="ExpressionConfigurationBase.Operators"/>.
    /// </summary>
    public class ExpressionConfigurationOperator
    {
        /// <summary>
        /// The <see cref="Operator"/>.
        /// </summary>
        public Operator ExpressionOperator;
        /// <summary>
        /// The <see cref="OperatorPrecedence"/>.
        /// </summary>
        public OperatorPrecedence ExpressionOperatorPrecedence;
        /// <summary>
        /// The <see cref="OperatorType"/>.
        /// </summary>
        public OperatorType ExpressionOperatorType;
        /// <summary>
        /// The name of the operator.
        /// </summary>
        public string OperatorName;
        /// <summary>
        /// Callback before the operator expression is solved.
        /// </summary>
        public Action<ExpressionGroup> OnBeforeOperatorExpressionSolved;
        /// <summary>
        /// Callback after the operator expression has been solved.
        /// </summary>
        public Action<ExpressionResult> OnAfterOperatorExpressionSolved;
        /// <summary>
        /// Callback for solving the operator expression yourself.
        /// </summary>
        public Func<ExpressionGroup, ExpressionResult> SolveOperatorExpression;
    }
}
