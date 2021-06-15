## Overview

**Table of Contents**
- [C# Expressions](#csharp-expressions)
- [HL7 Expressions](#hl7-expressions)
- [Links](#links)

### CSharp Expressions

C# .NET Library that will evaluate any math, string, or boolean expression using [Expression Configurations](ExpressionConfigurations.html). Expression Configurations are what the [Evaluator](/api/ExpressionEvaluatorForDotNet.Evaluator.html) uses when evaluating math (1+2), string ("a"+"b"), and boolean (1>2) expressions with operators like '+', '-', '||', and more. The expression configurations are fully customizable. Expressions support parentheses. Using Expression Configurations you can hook into when expressions are evaluated before and after or evaluate the expression yourself with custom logic. The default expression configuration is C#. 

### HL7 Expressions

You can also use this to evaluate segments of an [hl7v2 pipe delimited message](https://en.wikipedia.org/wiki/Health_Level_7). Using an [HL7V2ExpressionConfiguration](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html) the Evaluator can be configured to parse and return a structured [HL7V2Message](/api/ExpressionEvaluatorForDotNet.HL7V2Message.html) object layered with [fields](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html), [field repetitions](/api/ExpressionEvaluatorForDotNet.HL7V2FieldRepetition.html), [components](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html), and [subcomponents](/api/ExpressionEvaluatorForDotNet.HL7V2SubComponent.html). You can also perform CRUD operations on all of them, build a message from scratch, and more.

### Links

Please see [Examples](Examples.html) for how to use.