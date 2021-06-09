using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{
    public abstract class ExpressionConfigurationBase
    {
        public virtual IList<ExpressionConfigurationOperator> MathStringOperators
        {
            get
            {
                return Operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        public virtual IList<ExpressionConfigurationOperator> BooleanOperators
        {
            get
            {
                return Operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        public abstract IList<ExpressionConfigurationOperator> Operators { get; }

        public abstract ExpressionConfigurationOptions Options { get; }

        public ExpressionResult DefaultExpressionResult => new ExpressionResult
        {
            Value = "\"done\"",
            Type = VariableType.String
        };

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