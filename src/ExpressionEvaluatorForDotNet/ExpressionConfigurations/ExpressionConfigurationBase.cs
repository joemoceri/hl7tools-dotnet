using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// This abstract base class is what all expression configurations must derive from.
    /// </summary>
    public abstract class ExpressionConfigurationBase
    {
        /// <summary>
        /// Get all operators where the <see cref="ExpressionConfigurationOperator.ExpressionOperatorType"/> equals <see cref="OperatorType.MathString"/>.
        /// </summary>
        public virtual IList<ExpressionConfigurationOperator> MathStringOperators
        {
            get
            {
                return Operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        /// <summary>
        /// Get all operators where the <see cref="ExpressionConfigurationOperator.ExpressionOperatorType"/> equals <see cref="OperatorType.Boolean"/>.
        /// </summary>
        public virtual IList<ExpressionConfigurationOperator> BooleanOperators
        {
            get
            {
                return Operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        /// <summary>
        /// Gets a list of <see cref="ExpressionConfigurationOperator"/>.
        /// </summary>
        public abstract IList<ExpressionConfigurationOperator> Operators { get; }

        /// <summary>
        /// Gets the options for the expression configuration.
        /// </summary>
        public abstract ExpressionConfigurationOptions Options { get; }

        /// <summary>
        /// The default <see cref="ExpressionResult"/>.
        /// </summary>
        public ExpressionResult DefaultExpressionResult => new ExpressionResult
        {
            Value = "\"done\"",
            Type = VariableType.String
        };

        /// <summary>
        /// Creates an <see cref="ExpressionConfigurationOperator"/> with the provided values.
        /// </summary>
        /// <param name="expressionOperator">The <see cref="Operator"/>.</param>
        /// <param name="operatorPrecedence">The <see cref="OperatorPrecedence"/>.</param>
        /// <param name="expressionOperatorType">The <see cref="OperatorType"/>.</param>
        /// <param name="operatorName">The name value of the operator.</param>
        /// <param name="solveOperatorExpression"><see cref="Func{ExpressionGroup, ExpressionResult}"/> callback.</param>
        /// <param name="onBeforeOperatorExpressionSolved"><see cref="Action{ExpressionGroup}"/> callback.</param>
        /// <param name="onAfterOperatorExpressionSolved"><see cref="Action{ExpressionResult}"/> callback.</param>
        /// <returns><see cref="ExpressionConfigurationOperator"/>.</returns>
        protected ExpressionConfigurationOperator CreateExpressionConfigurationOperator(
    Operator expressionOperator,
    OperatorPrecedence operatorPrecedence,
    OperatorType expressionOperatorType,
    string operatorName,
    Func<ExpressionGroup, ExpressionResult> solveOperatorExpression = null,
    Action<ExpressionGroup> onBeforeOperatorExpressionSolved = null,
    Action<ExpressionResult> onAfterOperatorExpressionSolved = null)
        {
            return new ExpressionConfigurationOperator
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
    }
}