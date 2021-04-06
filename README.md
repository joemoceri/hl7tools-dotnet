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
			var answer = new ExpressionResult { Value = "\"5example\"", Type = VariableType.String };
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

Example #2: Parentheses can be handled
```csharp
			// Arrange
			var answer = new ExpressionResult { Value = "\"5example275\"", Type = VariableType.String }; ;
			var exp = "5 * 3 / 3 + ((\"example2\") + (5 * 15))";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			
			// produces an ExpressionResult that looks like this
			// Value = "\"5example275\""
			// Type = VariableType.String
			// Error = null
```

Example #3: Single boolean value
```csharp
			// Arrange
			var answer = new ExpressionResult { Value = "True", Type = VariableType.Boolean };
			var exp = "True";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			
			// produces an ExpressionResult that looks like this
			// Value = "True"
			// Type = VariableType.Boolean
			// Error = null
```

Example #4: Hooking into OnBeforeOperatorExpressionSolved
```csharp
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();
			
			// get the operator
			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			// Each time it evaluates an 'addition' operation, increment the count
			additionOperator.OnBeforeOperatorExpressionSolved = (expGroup) =>
			{
				count++;
			};

			solver = new Evaluator(languageTemplate);

			var answer = new ExpressionResult 
			{
				Value = "3", Type = VariableType.Int 
			};

			// simple expression to test
			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			
			// should increment
			Assert.AreEqual(count, 1);

			solver.Evaluate(exp);

			// here too
			Assert.AreEqual(count, 2);

			// null it out
			additionOperator.OnBeforeOperatorExpressionSolved = null;

			solver.Evaluate(exp);

			// shouldn't be incremented
			Assert.AreEqual(count, 2);
```

Example #5: Hooking into OnAfterOperatorExpressionSolved
```csharp
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var count = 0;

			additionOperator.OnAfterOperatorExpressionSolved = (expressionResult) =>
			{
				// the expression is known, so this is safe, and the point. You're in control.
				var v = int.Parse(expressionResult.Value);

				count += v;
			};

			solver = new Evaluator(languageTemplate);

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert
			Assert.AreEqual(count, 3);

			solver.Evaluate(exp);

			Assert.AreEqual(count, 6);

			additionOperator.OnAfterOperatorExpressionSolved = null;

			solver.Evaluate(exp);

			// shouldn't be incremented
			Assert.AreEqual(count, 6);
```

Example #6: Hooking into SolveOperatorExpression
```csharp
			// Arrange
			var languageTemplate = new EEExpressionsLanguageTemplate();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				return new ExpressionResult
				{
					Value = "0",
					Type = VariableType.Int
				};
			};

			solver = new Evaluator(languageTemplate);

			var answer = new ExpressionResult
			{
				Value = "0",
				Type = VariableType.Int
			};

			var exp = "1+2";

			// Act
			var result = solver.Evaluate(exp);

			// Assert: Will be 0, not 3 because of the addition overwrite
			Assert.AreEqual(answer, result);
```
