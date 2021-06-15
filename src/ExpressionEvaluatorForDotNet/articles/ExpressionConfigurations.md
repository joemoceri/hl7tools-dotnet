### Expression Configurations
Expression Configurations are customizable settings you use to change the behavior of the Evaluator.

The default is [CSharpExpressionConfiguration](/api/ExpressionEvaluatorForDotNet.CSharpExpressionConfiguration.html) which inherits from [ExpressionConfigurationBase](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationBase.html). Using [HL7V2ExpressionConfiguration](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html) allows HL7V2 message parsing. To create your own Expression Configuration, inherit from ExpressionConfigurationBase.