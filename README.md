# expression-evaluator

> Expression Evaluator is built for C# .NET and will evaluate math, string and boolean arithmetic expressions given a language template.

* [Overview](#overview)
* [Install](#install)
* [Usage](#usage)

<a name="overview"></a>
## Overview
This is a project written in C# that will, given a math, string or boolean expression, evaluate it using a built-in Language Template called EE Expressions. Language Templates are what the Expression Evaluator uses when defining math, string, and boolean operators like '+', '-', '||', and so on.  EE Expressions is influenced by Python syntax by default, but the operations are fully customizable. Using this Language Template you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic.

Not Supported:
 * Single quotes (') as strings. You must use double quotes (") for strings. You can still use single quotes inside strings, and escaped double quotes.
 * Customizing what defines a quote, a parentheses (())

For example, if you have an expression in C# like '1 > 2', it will return 'False', with a type of Boolean. You can hook into the '>' operator with the following methods: OnBeforeOperatorExpressionSolved (before the expression is solved), OnAfterOperatorExpressionSolved (after the expression is solved), SolveOperatorExpression (override the default behaviour and solve it yourself). You can also customize the operator to use 'greater-than' as an operator instead of '>', so that '1 greater-than 2' will return 'False' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called ExpressionResult that contains the value, variable type, and error, if any. Please see Usage for examples.

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
			Evaluator solver = new Evaluator();
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
			var answer = new ExpressionResult { Value = "\"5example275\"", Type = VariableType.String };
			var exp = "5 * 3 / 3 + ((\"example2\") + (5 * 15))";

			// Act
			Evaluator solver = new Evaluator();
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
			Evaluator solver = new Evaluator();
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

			Evaluator solver = new Evaluator(languageTemplate);

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

			Evaluator solver = new Evaluator(languageTemplate);

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

			Evaluator solver = new Evaluator(languageTemplate);

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

Example #7: HL7 Message MSH Line Expression Evaluation 
```csharp
			// Arrange
			var answer = new ExpressionResult
			{
				Value = "\"done\"",
				Type = VariableType.String
			};

			var languageTemplate = new HL7MshExpressionsLanguageTemplate();

			var parts = new List<Hl7MshPart>();

			var additionOperator = languageTemplate.MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

			var delimiterCount = 0;

			additionOperator.SolveOperatorExpression = (expGroup) =>
			{
				// this is the real work. Check the right operand for your value, the left will be whatever is being returned after the first time, in this case the string "done"
				delimiterCount++;
				parts.Add(new Hl7MshPart
				{
					DelimiterIndex = delimiterCount,
					LeftOperand = expGroup.LeftOperand,
					RightOperand = expGroup.RightOperand
				});

				// just return something to make the evaluator happy. The final expression will always be this if it runs successfully.
				return answer;
			};


			solver = new Evaluator(languageTemplate);

			var exp = "MSH|^~\\&|EPIC|EPICADT|SMS|SMSADT|199912271408|CHARRIS|ADT^A04|1817457|D|2.5|";

			// Act
			var result = solver.Evaluate(exp);

			foreach (var part in parts)
            		{
				// do whatever you need to here
            		}

            		// Assert
            		Assert.AreEqual(answer, result);
```

To create your own LanguageTemplate, inherit from [LanguageTemplateBase](https://github.com/jmoceri34/expression-evaluator/blob/5270bdf7b600050cd3496eb2e7f094aa5a83693f/ExpressionEvaluator/Io.JoeMoceri.ExpressionEvaluator/LanguageTemplate/LanguageTemplateBase.cs#L5)

Please see Io.JoeMoceri.ExpressionEvaluator.Sample project for usage.

Sample.cs

```csharp
using Io.JoeMoceri.ExpressionEvaluator.LanguageTemplate;
using System;
using System.Collections.Generic;
using System.IO;

namespace Io.JoeMoceri.ExpressionEvaluator.Sample
{
    public class App
    {
        public void Run()
        {
            ParseHL7FileExample();

            Console.ReadLine();
        }

        public void ParseHL7FileExample()
        {
            var lines = File.ReadLines("HL7File.txt");

            var languageTemplate = new HL7ExpressionsLanguageTemplate();

            var evaluator = new Evaluator(languageTemplate);

            var results = new List<HL7Result>();

            foreach (var line in lines)
            {
                evaluator.Evaluate(line);

                var hl7Result = languageTemplate.GetHL7Result();

                Console.WriteLine(hl7Result.ToString());

                results.Add(hl7Result);
            }

            Console.WriteLine("Final Output:");

            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}

```
