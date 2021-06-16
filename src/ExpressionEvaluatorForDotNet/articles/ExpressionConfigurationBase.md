### ExpressionConfigurationBase

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Links](#links)

#### Description

Inherit from this class to create your own ExpressionConfiguration.

#### Properties

- Virtual
  - [MathStringOperators](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationBase_MathStringOperators): A list of [ExpressionConfigurationOperator](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html) where their [ExpressionOperatorType](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_ExpressionOperatorType) equals [OperatorType.MathString](/api/ExpressionEvaluatorForDotNet.OperatorType.html#ExpressionEvaluatorForDotNet_OperatorType_MathString).

  - [BooleanOperators](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationBase_BooleanOperators): A list of [ExpressionConfigurationOperator](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html) where their [ExpressionOperatorType](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_ExpressionOperatorType) equals [OperatorType.Boolean](/api/ExpressionEvaluatorForDotNet.OperatorType.html#ExpressionEvaluatorForDotNet_OperatorType_Boolean).

- Abstract
  - [Operators](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationBase_Operators): A list of [ExpressionConfigurationOperator](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html).

  - [Options](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationBase_Options): The  [ExpressionConfigurationOptions](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOptions.html).

#### Links

[Link to the file](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html)