# expression-evaluator

> Expression Evaluator is built for C# .NET and will evaluate math, string and boolean arithmetic expressions given a language template.

* [Overview](#overview)
* [Install](#install)
* [Usage](#usage)

<a name="overview"></a>
## Overview
This is a project written in C# that will, given a math, string or boolean expression, evaluate it using built-in Language Templates. Language Templates are what the Expression Evaluator uses when defining math, string, and boolean operators like '+', '-', '||', and so on. The operations are fully customizable. Using Language Templates you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic. The default language template is Python.

Not Supported:
 * Single quotes (') as strings. You must use double quotes (") for strings. You can still use single quotes inside strings, and escaped double quotes.
 * Customizing what defines a quote and a parentheses (())

For example, if you have an expression in Python like '1 > 2', it will return 'False', with a type of Boolean. You can hook into the '>' operator with the following methods: OnBeforeOperatorExpressionSolved (before the expression is solved), OnAfterOperatorExpressionSolved (after the expression is solved), SolveOperatorExpression (override the default behavior and solve it yourself). You can also customize the operator to use 'greater-than' as an operator instead of '>', so that '1 greater-than 2' will return 'False' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called ExpressionResult that contains the value, variable type, and error, if any. Please see Usage for examples.

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
			Evaluator evaluator = new Evaluator();
			var result = evaluator.Evaluate(exp);

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
			Evaluator evaluator = new Evaluator();
			var result = evaluator.Evaluate(exp);

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
			Evaluator evaluator = new Evaluator();
			var result = evaluator.Evaluate(exp);

			// Assert
			Assert.AreEqual(answer, result);
			
			// produces an ExpressionResult that looks like this
			// Value = "True"
			// Type = VariableType.Boolean
			// Error = null
```

To create your own LanguageTemplate, inherit from [LanguageTemplateBase](https://github.com/jmoceri34/expression-evaluator/blob/master/ExpressionEvaluator/Io.JoeMoceri.ExpressionEvaluator/LanguageTemplate/LanguageTemplateBase.cs#L5)

Please see Io.JoeMoceri.ExpressionEvaluator.Sample project for usage.

App.cs

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

            var languageTemplate = new HL7V2LanguageTemplate();

            var evaluator = new Evaluator(languageTemplate);

            var messageSegments = new List<HL7V2MessageSegment>();

            foreach (var line in lines)
            {
                evaluator.Evaluate(line);

                var messageSegment = languageTemplate.GetHL7V2MessageSegment();

                Console.WriteLine(messageSegment.ToString());

                messageSegments.Add(messageSegment);
            }

            Console.WriteLine("Final Output:");

            foreach (var messageSegment in messageSegments)
            {
                Console.WriteLine(messageSegment.ToString());
            }
        }
    }
}

```
