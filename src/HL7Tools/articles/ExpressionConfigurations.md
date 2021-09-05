### Expression Configurations
Expression Configurations are customizable settings you use to change the behavior of the Evaluator.

The default is [CSharpExpressionConfiguration](../api/HL7Tools.CSharpExpressionConfiguration.html) which inherits from [ExpressionConfigurationBase](../api/HL7Tools.ExpressionConfigurationBase.html). Using [HL7V2ExpressionConfiguration](../api/HL7Tools.HL7V2ExpressionConfiguration.html) allows HL7V2 message parsing. To create your own Expression Configuration, inherit from ExpressionConfigurationBase.