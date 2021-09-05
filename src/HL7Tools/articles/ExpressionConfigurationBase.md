### ExpressionConfigurationBase

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Links](#links)

#### Description

Inherit from this class to create your own ExpressionConfiguration.

#### Properties

- Virtual
  - [MathStringOperators](../api/HL7Tools.ExpressionConfigurationBase.html#HL7Tools_ExpressionConfigurationBase_MathStringOperators): A list of [ExpressionConfigurationOperator](../api/HL7Tools.ExpressionConfigurationOperator.html) where their [ExpressionOperatorType](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_ExpressionOperatorType) equals [OperatorType.MathString](../api/HL7Tools.OperatorType.html#HL7Tools_OperatorType_MathString).

  - [BooleanOperators](../api/HL7Tools.ExpressionConfigurationBase.html#HL7Tools_ExpressionConfigurationBase_BooleanOperators): A list of [ExpressionConfigurationOperator](../api/HL7Tools.ExpressionConfigurationOperator.html) where their [ExpressionOperatorType](../api/HL7Tools.ExpressionConfigurationOperator.html#HL7Tools_ExpressionConfigurationOperator_ExpressionOperatorType) equals [OperatorType.Boolean](../api/HL7Tools.OperatorType.html#HL7Tools_OperatorType_Boolean).

- Abstract
  - [Operators](../api/HL7Tools.ExpressionConfigurationBase.html#HL7Tools_ExpressionConfigurationBase_Operators): A list of [ExpressionConfigurationOperator](../api/HL7Tools.ExpressionConfigurationOperator.html).

  - [Options](../api/HL7Tools.ExpressionConfigurationBase.html#HL7Tools_ExpressionConfigurationBase_Options): The  [ExpressionConfigurationOptions](../api/HL7Tools.ExpressionConfigurationOptions.html).

#### Links

[Link to the file](../api/HL7Tools.ExpressionConfigurationBase.html)