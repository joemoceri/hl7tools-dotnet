### C# Expressions
For the C# Expression Configuration, if you try to [Evaluate](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/ExpressionEvaluatorForDotNet/Evaluator/Evaluator.cs#L101) '1 > 2', it will return 'false', with a type of Boolean. You can hook into operators with the following methods: [OnBeforeOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L14) (before the expression is solved), [OnAfterOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L15) (after the expression is solved), [SolveOperatorExpression](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/ExpressionEvaluatorForDotNet/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L16) (override the default behavior and solve it yourself). You can also customize operators, such as changing '>' to 'greater-than' as an operator so that '1 greater-than 2' will return 'false' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called [ExpressionResult](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/ExpressionEvaluatorForDotNet/Evaluator/ExpressionResult.cs#L8) that contains the value, variable type, and error, if any.

Here's an example

```csharp
public void SolveMathExample()
{
    var evaluator = new Evaluator();

    var r = 1 + 2 * (3 - 4) / 18;

    var result = evaluator.Evaluate("1 + 2 * (3 - 4) / 18");

    Console.WriteLine($"{r} = {result}");

    // outputs
    // 1 = 1
}
```