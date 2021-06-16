### ExpressionConfigurationOperator

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Links](#links)

#### Description

This is used inside of ExpressionConfigurations when defining the operators that should be used. A protected method on [ExpressionConfigurationBase](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html) named [CreateExpressionConfigurationOperator](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationBase_CreateExpressionConfigurationOperator_ExpressionEvaluatorForDotNet_Operator_ExpressionEvaluatorForDotNet_OperatorPrecedence_ExpressionEvaluatorForDotNet_OperatorType_System_String_System_Func_ExpressionEvaluatorForDotNet_ExpressionGroup_ExpressionEvaluatorForDotNet_ExpressionResult__System_Action_ExpressionEvaluatorForDotNet_ExpressionGroup__System_Action_ExpressionEvaluatorForDotNet_ExpressionResult__) uses it to generate operators for ExpressionConfigurations. Please see inside each expression configuration for usage.

#### Properties

- [ExpressionOperator](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_ExpressionOperator): The [Operator](/api/ExpressionEvaluatorForDotNet.Operator.html)
- [ExpressionOperatorPrecedence](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_ExpressionOperatorPrecedence): The [OperatorPrecedence](/api/ExpressionEvaluatorForDotNet.OperatorPrecedence.html)
- [ExpressionOperatorType](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_ExpressionOperatorType): The [OperatorType](/api/ExpressionEvaluatorForDotNet.OperatorType.html)
- [OperatorName](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_OperatorName): The name of the operator (+, -, %, /, so on)
- [OnBeforeOperatorExpressionSolved](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_OnBeforeOperatorExpressionSolved): An action you can hook into to invoke before an operator (inner) expression is solved.
- [OnAfterOperatorExpressionSolved](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_OnAfterOperatorExpressionSolved): An action you can hook into to invoke after an operator (inner) expression is solved.
- [SolveOperatorExpression](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_SolveOperatorExpression): A Func you can hook into to invoke and override solving an operator (inner) expression.

#### Links
[Link to the file](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html)