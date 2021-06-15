### C# Expressions
For the [C# Expression Configuration](/api/ExpressionEvaluatorForDotNet.CSharpExpressionConfiguration.html), if you try to [Evaluate](/api/ExpressionEvaluatorForDotNet.Evaluator.html#ExpressionEvaluatorForDotNet_Evaluator_Evaluate_System_String_) '1 > 2', it will return 'false', with a type of Boolean. You can hook into operators with the following methods: [OnBeforeOperatorExpressionSolved](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_OnBeforeOperatorExpressionSolved) (before the expression is solved), [OnAfterOperatorExpressionSolved](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_OnAfterOperatorExpressionSolved) (after the expression is solved), [SolveOperatorExpression](/api/ExpressionEvaluatorForDotNet.ExpressionConfigurationOperator.html#ExpressionEvaluatorForDotNet_ExpressionConfigurationOperator_SolveOperatorExpression) (override the default behavior and solve it yourself). You can also customize operators, such as changing '>' to 'greater-than' as an operator so that '1 greater-than 2' will return 'false' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called [ExpressionResult](/api/ExpressionEvaluatorForDotNet.ExpressionResult.html) that contains the value, variable type, and error, if any.

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