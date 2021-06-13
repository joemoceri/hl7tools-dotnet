### CSharpExpressionConfiguration

[Link to the file](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/CSharp/CSharpExpressionConfiguration.cs)

CSharpExpressionConfiguration exposes two properties:

- [Operators](https://github.com/jmoceri34/expression-evaluator/blob/1e77ad47edda02dbec338309e5c53a0125362e98/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/CSharp/CSharpExpressionConfiguration.cs#L55): Returns a list of ExpressionConfigurationOperator.

- [Options](https://github.com/jmoceri34/expression-evaluator/blob/1e77ad47edda02dbec338309e5c53a0125362e98/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/CSharp/CSharpExpressionConfiguration.cs#L57): Returns ExpressionConfigurationOptions.

The default options are the following:
```csharp
options = new ExpressionConfigurationOptions
{
    IgnoreWhitespaceOutsideQuotes = false,
    IgnoreParentheses = false,
    IgnoreQuotesValidation = false
};
```
- IgnoreWhitespaceOutsideQuotes: By default the CSharpExpressionConfiguration removes whitespace outside of quotes inside of the expression, so this is set to **false**.

- IgnoreParentheses: By default the CSharpExpressionConfiguration breaks expressions down from the outer most parentheses set to the inner most, so this is set to **false**.

- IgnoreQuotesValidation: By default the CSharpExpressionConfiguration validates if there are a balanced (1:1 ratio) set of quotes inside of the expression, so this is set to **false**.

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

Inside of the Evaluator, higher precedence operators are solved first, followed by lower precedence operators. Only the operators shown are supported.
