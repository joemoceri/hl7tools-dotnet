using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ExpressionConfigurationBase
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<ExpressionConfigurationOperator> MathStringOperators
        {
            get
            {
                return Operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual IList<ExpressionConfigurationOperator> BooleanOperators
        {
            get
            {
                return Operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract IList<ExpressionConfigurationOperator> Operators { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract ExpressionConfigurationOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExpressionResult DefaultExpressionResult => new ExpressionResult
        {
            Value = "\"done\"",
            Type = VariableType.String
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expressionOperator"></param>
        /// <param name="operatorPrecedence"></param>
        /// <param name="expressionOperatorType"></param>
        /// <param name="operatorName"></param>
        /// <param name="solveOperatorExpression"></param>
        /// <param name="onBeforeOperatorExpressionSolved"></param>
        /// <param name="onAfterOperatorExpressionSolved"></param>
        /// <returns></returns>
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