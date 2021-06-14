### ExpressionConfigurationBase

[Link to the file](https://github.com/jmoceri34/expression-evaluator/blob/master/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationBase.cs)

Inherit from this class to create your own ExpressionConfiguration.

This exposes two virtual and two abstract properties:

- Virtual
  - [MathStringOperators](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationBase.cs#L9): A list of ExpressionConfigurationOperator where their ExpressionOperatorType equals OperatorType.MathString.

  - [BooleanOperators](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationBase.cs#L17): A list of ExpressionConfigurationOperator where their ExpressionOperatorType equals OperatorType.Boolean.

- Abstract
  - [Operators](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationBase.cs#L25): A list of ExpressionConfigurationOperator.

  - [Options](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationBase.cs#L27): ExpressionConfigurationOptions.
