using System;

namespace HL7Tools
{
    /// <summary>
    /// This class represents an operator to an <see cref="ExpressionConfigurationBase.Operators"/>.
    /// </summary>
    public class ExpressionConfigurationOperator
    {
        /// <summary>
        /// The <see cref="Operator"/>.
        /// </summary>
        public Operator ExpressionOperator { get; set; }
        /// <summary>
        /// The <see cref="OperatorPrecedence"/>.
        /// </summary>
        public OperatorPrecedence ExpressionOperatorPrecedence { get; set; }
        /// <summary>
        /// The <see cref="OperatorType"/>.
        /// </summary>
        public OperatorType ExpressionOperatorType { get; set; }
        /// <summary>
        /// The name of the operator.
        /// </summary>
        public string OperatorName { get; set; }
        /// <summary>
        /// Callback before the operator expression is solved.
        /// </summary>
        public Action<ExpressionGroup> OnBeforeOperatorExpressionSolved { get; set; }
        /// <summary>
        /// Callback after the operator expression has been solved.
        /// </summary>
        public Action<ExpressionResult> OnAfterOperatorExpressionSolved { get; set; }
        /// <summary>
        /// Callback for solving the operator expression yourself.
        /// </summary>
        public Func<ExpressionGroup, ExpressionResult> SolveOperatorExpression { get; set; }
    }
}
