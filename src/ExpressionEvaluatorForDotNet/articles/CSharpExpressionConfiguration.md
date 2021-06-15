### CSharpExpressionConfiguration

[Link to the file](/api/ExpressionEvaluatorForDotNet.CSharpExpressionConfiguration.html)

Use this class to evaluate math (1+2), string ("a"+"b"), or boolean (1>2) expressions.

Properties

- [Operators](/api/ExpressionEvaluatorForDotNet.CSharpExpressionConfiguration.html#ExpressionEvaluatorForDotNet_CSharpExpressionConfiguration_Operators): Returns a list of [ExpressionConfigurationOperator](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html).

- [Options](/api/ExpressionEvaluatorForDotNet.CSharpExpressionConfiguration.html#ExpressionEvaluatorForDotNet_CSharpExpressionConfiguration_Options): Returns [ExpressionConfigurationOptions](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOptions.html).

The default options are the following:
```csharp
options = new ExpressionConfigurationOptions
{
    IgnoreWhitespaceOutsideQuotes = false,
    IgnoreParentheses = false,
    IgnoreQuotesValidation = false
};
```
- [IgnoreWhitespaceOutsideQuotes](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOptions.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOptions_IgnoreWhitespaceOutsideQuotes): By default the CSharpExpressionConfiguration removes whitespace outside of quotes inside of the expression, so this is set to **false**.

- [IgnoreParentheses](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOptions.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOptions_IgnoreParentheses): By default the CSharpExpressionConfiguration breaks expressions down from the outer most parentheses set to the inner most, so this is set to **false**.

- [IgnoreQuotesValidation](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOptions.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOptions_IgnoreQuotesValidation): By default the CSharpExpressionConfiguration validates if there are a balanced (1:1 ratio) set of quotes inside of the expression, so this is set to **false**.

The default operators are the following:
```csharp
operators = new List<ExpressionConfigurationOperator>
{
    CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, "+"),
    CreateExpressionConfigurationOperator(Operator.Subtraction, OperatorPrecedence.Lower, OperatorType.MathString, "-"),
    CreateExpressionConfigurationOperator(Operator.Multiplication, OperatorPrecedence.Higher, OperatorType.MathString, "*"),
    CreateExpressionConfigurationOperator(Operator.Division, OperatorPrecedence.Higher, OperatorType.MathString, "/"),
    CreateExpressionConfigurationOperator(Operator.Modulus, OperatorPrecedence.Higher, OperatorType.MathString, "%"),
    CreateExpressionConfigurationOperator(Operator.And, OperatorPrecedence.Lower, OperatorType.Boolean, "&&"),
    CreateExpressionConfigurationOperator(Operator.Or, OperatorPrecedence.Lower, OperatorType.Boolean, "||"),
    CreateExpressionConfigurationOperator(Operator.LessThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "<="),
    CreateExpressionConfigurationOperator(Operator.GreaterThanOrEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, ">="),
    CreateExpressionConfigurationOperator(Operator.EqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "=="),
    CreateExpressionConfigurationOperator(Operator.NotEqualTo, OperatorPrecedence.Higher, OperatorType.Boolean, "!="),
    CreateExpressionConfigurationOperator(Operator.LessThan, OperatorPrecedence.Higher, OperatorType.Boolean, "<"),
    CreateExpressionConfigurationOperator(Operator.GreaterThan, OperatorPrecedence.Higher, OperatorType.Boolean, ">"),
};
```

Inside of the [Evaluator](/api/ExpressionEvaluatorForDotNet.Evaluator.html), [higher precedence operators](/api/ExpressionEvaluatorForDotNet.OperatorPrecedence.html#ExpressionEvaluatorForDotNet_OperatorPrecedence_Higher) are solved first, followed by [lower precedence operators](/api/ExpressionEvaluatorForDotNet.OperatorPrecedence.html#ExpressionEvaluatorForDotNet_OperatorPrecedence_Lower). Only the operators shown are supported.
