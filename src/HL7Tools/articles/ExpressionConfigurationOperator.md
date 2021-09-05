### ExpressionConfigurationOperator

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Links](#links)

#### Description

This is used inside of ExpressionConfigurations when defining the operators that should be used. A protected method on [ExpressionConfigurationBase](../api/HL7Tools.ExpressionConfigurationBase.html) named [CreateExpressionConfigurationOperator](../api/HL7Tools.ExpressionConfigurationBase.html#HL7Tools_ExpressionConfigurationBase_CreateExpressionConfigurationOperator_HL7Tools_Operator_HL7Tools_OperatorPrecedence_HL7Tools_OperatorType_System_String_System_Func_HL7Tools_ExpressionGroup_HL7Tools_ExpressionResult__System_Action_HL7Tools_ExpressionGroup__System_Action_HL7Tools_ExpressionResult__) uses it to generate operators for ExpressionConfigurations. Please see inside each expression configuration for usage.

#### Properties

- [ExpressionOperator](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_ExpressionOperator): The [Operator](../api/HL7Tools.Operator.html)
- [ExpressionOperatorPrecedence](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_ExpressionOperatorPrecedence): The [OperatorPrecedence](../api/HL7Tools.OperatorPrecedence.html)
- [ExpressionOperatorType](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_ExpressionOperatorType): The [OperatorType](../api/HL7Tools.OperatorType.html)
- [OperatorName](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_OperatorName): The name of the operator (+, -, %, /, so on)
- [OnBeforeOperatorExpressionSolved](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_OnBeforeOperatorExpressionSolved): An action you can hook into to invoke before an operator (inner) expression is solved.
- [OnAfterOperatorExpressionSolved](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_OnAfterOperatorExpressionSolved): An action you can hook into to invoke after an operator (inner) expression is solved.
- [SolveOperatorExpression](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_SolveOperatorExpression): A Func you can hook into to invoke and override solving an operator (inner) expression.

#### Links
[Link to the file](../api/HL7Tools.ExpressionConfigurationOperator.html)