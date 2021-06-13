### ExpressionConfigurationOperator

This is used inside of ExpressionConfigurations when defining the operators that should be used. A protected method on ExpressionConfigurationBase named CreateExpressionConfigurationOperator uses it to generate operators for ExpressionConfigurations. Please see inside each expression configuration for usage.

It exposes the following values

- ExpressionOperator: The Operator
- ExpressionOperatorPrecedence: The OperatorPrecedence
- ExpressionOperatorType: The OperatorType
- OperatorName: The name of the operator (+, -, %, /, so on)
- OnBeforeOperatorExpressionSolved: An action you can hook into to invoke before an operator (inner) expression is solved.
- OnAfterOperatorExpressionSolved: An action you can hook into to invoke after an operator (inner) expression is solved.
- SolveOperatorExpression: A Func you can hook into to invoke and override solving an operator (inner) expression.