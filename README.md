# expression-evaluator

> Expression Evaluator is built for C# .NET and will evaluate math, string and boolean arithmetic expressions given a language template.

* [Overview](#overview)
* [Install](#install)
* [Usage](#usage)

<a name="overview"></a>
## Overview
This is a project written in C# that will, given a math, string or boolean expression, evaluate it using a built-in Language Template called EE Expressions. Using this Language Template you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic.

For example, if you have an expression in C# like '1 > 2', it will return 'True', with a type of Boolean. The operator '>' you can hook into with the following methods: OnBeforeOperatorExpressionSolved (before the expression is solved), OnAfterOperatorExpressionSolved (after the expression is solved), SolveOperatorExpression (override the default behaviour and solve it yourself). You can also use 'greater-than' as an operator instead of '>'. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called ExpressionResult that contains the value, variable type, and error, if any. Please see Usage for examples.

<a name="install"></a>
## Install
Using NuGet
```sh
Install-Package Io.JoeMoceri.ExpressionEvaluator
```

<a name="usage"></a>
## Usage

Please see Tests section of project for examples on how to use it and below.

Example #1: No parentheses order of operations

```csharp
			// Arrange
			var answer = new ExpressionResult { Value = "\"5example\"", Type = VariableType.String }; ;
			var exp = "5 * 3 / 3 + \"example\"";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
      
      // produces an ExpressionResult that looks like this
			// Value = "\"5example\""
			// Type = VariableType.String
			// Error = null
```
