# Expression Evaluator for .NET

[![NuGet](https://img.shields.io/nuget/v/Io.JoeMoceri.ExpressionEvaluator.svg)](https://www.nuget.org/packages/Io.JoeMoceri.ExpressionEvaluator/) ![GitHub Workflow](https://github.com/jmoceri34/expression-evaluator/actions/workflows/dotnet.yml/badge.svg) 

This is a project written in C# that will, given a math, string or boolean expression, evaluate it using built-in Expression Configurations. Expression Configurations are what the Expression Evaluator uses when defining math, string, and boolean operators like '+', '-', '||', and so on. The operations are fully customizable. Using Expression Configurations you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic. The default expression configuration is C#. You can also use this to evaluate segments of an hl7v2 pipe delimited message. Using an HL7V2ExpressionConfiguration the Evaluator can be configured to parse and return a structured HL7V2Message object layered with fields, field repetitions, components, and subcomponents. You can also perform CRUD operations on all of them, build a message from scratch, and more.

Not Supported:
 * Single quotes (') as strings. You must use double quotes (") for strings. You can still use single quotes inside strings, and escaped double quotes.
 * Customizing what defines a quote and a parentheses (()).
 * Bitwise operations and anything else not +,-,*,/,%,&&,||,>,<,>=,<=,==, !=, int, float, or boolean.


For the C# Expression Configuration, if you try to [Evaluate](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/Evaluator/Evaluator.cs#L101) '1 > 2', it will return 'false', with a type of Boolean. You can hook into the '>' operator with the following methods: [OnBeforeOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L14) (before the expression is solved), [OnAfterOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L15) (after the expression is solved), [SolveOperatorExpression](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L16) (override the default behavior and solve it yourself). You can also customize the operator to use 'greater-than' as an operator instead of '>', so that '1 greater-than 2' will return 'false' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called [ExpressionResult](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/Evaluator/ExpressionResult.cs#L8) that contains the value, variable type, and error, if any.

**Table of Contents**
- [Expression Evaluator for .NET](#expression-evaluator-for-net)
  - [Installation](#installation)
    - [Requirements](#requirements)
  - [Overview](#overview)
    - [C# Expressions](#c#-expressions)
    - [HL7V2 Message Segment Expressions](#hl7v2-message-segment-expressions)
    - [Expression Configurations](#expression-configurations)
  - [Reference & Examples](#reference-&-examples)
    - [C#](#c#)
    - [HL7V2Message](#hl7v2message)
    - [HL7V2MessageSegment](#hl7v2messagesegment)
    - [HL7V2Field](#hl7v2field)
    - [HL7V2FieldRepetition](#hl7v2fieldrepetition)
    - [HL7V2Component](#hl7v2component)
    - [HL7V2SubComponent](#hl7v2subcomponent)

<a name="install"></a>
## Installation
[NuGet Expression Evaluator package](https://www.nuget.org/packages/Io.JoeMoceri.ExpressionEvaluator/).

You can install using the following methods.

Using the .NET Core command-line interface (CLI) tools:

```sh
dotnet add package Io.JoeMoceri.ExpressionEvaluator
```

Using the NuGet Command Line Interface (CLI):

```sh
nuget install Io.JoeMoceri.ExpressionEvaluator
```

Using the Package Manager Console:

```powershell
Install-Package Io.JoeMoceri.ExpressionEvaluator
```

### Requirements
 - .NET 5.0+

## Overview
TBD
### C# Expressions
TBD
### HL7V2 Message Segment Expressions
TBD
### Expression Configurations
TBD

## Reference & Examples
TBD
### C#
TBD
### HL7V2Message
TBD
### HL7V2MessageSegment
TBD
### HL7V2Field
TBD
### HL7V2FieldRepetition
TBD
### HL7V2Component
TBD
### HL7V2SubComponent
TBD
