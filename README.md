# Expression Evaluator for .NET

[![NuGet](https://img.shields.io/nuget/v/Io.JoeMoceri.ExpressionEvaluator.svg)](https://www.nuget.org/packages/Io.JoeMoceri.ExpressionEvaluator/) ![GitHub Workflow](https://github.com/jmoceri34/expression-evaluator/actions/workflows/dotnet.yml/badge.svg) 

Expression Evaluator for .NET parses any C# math, boolean, or string expression. It also has capabilities for handling [HL7V2 pipe-delimited (|) flat files](https://en.wikipedia.org/wiki/Health_Level_Seven_International).

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
    - [ExpressionConfiguration](#expression-configuration)
    - [HL7V2Message](#hl7v2message)
    - [HL7V2MessageSegment](#hl7v2messagesegment)
    - [HL7V2Field](#hl7v2field)
    - [HL7V2FieldRepetition](#hl7v2fieldrepetition)
    - [HL7V2Component](#hl7v2component)
    - [HL7V2SubComponent](#hl7v2subcomponent)
  - [Roadmap](#roadmap)
  - [Contributing](#contributing)
  - [License](#license)



## Installation
[NuGet Expression Evaluator for .NET package](https://www.nuget.org/packages/Io.JoeMoceri.ExpressionEvaluator/).

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
This is a project written in C# that will, given a math, string or boolean expression, evaluate it using built-in Expression Configurations. Expression Configurations are what the Evaluator uses when defining math, string, and boolean operators like '+', '-', '||', and so on. The operations are fully customizable. Using Expression Configurations you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic. The default expression configuration is C#. 

You can also use this to evaluate segments of an hl7v2 pipe delimited message. Using an HL7V2ExpressionConfiguration the Evaluator can be configured to parse and return a structured HL7V2Message object layered with fields, field repetitions, components, and subcomponents. You can also perform CRUD operations on all of them, build a message from scratch, and more.

### C# Expressions
For the C# Expression Configuration, if you try to [Evaluate](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/Evaluator/Evaluator.cs#L101) '1 > 2', it will return 'false', with a type of Boolean. You can hook into the '>' operator with the following methods: [OnBeforeOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L14) (before the expression is solved), [OnAfterOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L15) (after the expression is solved), [SolveOperatorExpression](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L16) (override the default behavior and solve it yourself). You can also customize the operator to use 'greater-than' as an operator instead of '>', so that '1 greater-than 2' will return 'false' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called [ExpressionResult](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/Evaluator/ExpressionResult.cs#L8) that contains the value, variable type, and error, if any.

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

### HL7V2 Message Segment Expressions

Expression Evaluator can parse hl7v2 message segments, such as the MSH segment below
```
MSH|^~\&|Ntierprise|Ntierprise Clinic|Healthmatics EHR|Healthmatics Clinic|20190423113910||ADT^A08|8899-39|P|2.3|||NE|NE
```
So that you can write the following
```csharp
var expressionConfiguration = new HL7V2ExpressionConfiguration();

var evaluator = new Evaluator(expressionConfiguration);

var message = evaluator.EvaluateHL7V2File(new [] { @"MSH|^~\&|Ntierprise|Ntierprise Clinic|Healthmatics EHR|Healthmatics Clinic|20190423113910||ADT^A08|8899-39|P|2.3|||NE|NE" });

var msh4 = message.Get("MSH.4");

Console.WriteLine(msh4.Value);
// outputs 
// "Ntierprise Clinic"
```


### Expression Configurations
The default is [CSharpExpressionConfiguration](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/CSharp/CSharpExpressionConfiguration.cs) which inherits from [ExpressionConfigurationBase](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs). You can customize the evaluator through Expression Configurations, such as [HL7V2ExpressionConfiguration](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/HL7V2/HL7V2ExpressionConfiguration.cs) to allow HL7V2 message parsing.

## Reference & Examples
TBD
### C#
TBD
### Expression Configuration
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

## Roadmap
* Version objects for HL7
* MLLP for HL7
* JSON support for HL7
* Validation for HL7
* ACK and NACK for HL7
* Multiple languages. JavaScript, Java, Go, Elixir, Rust, Python, Swift.

## Contributing
Right now it's just me. If you could follow this flow, that would make it easier to keep track of changes. Contributions should be handled with the following git workflow.

1) Fork the repo on GitHub
2) Clone the project to your machine
3) Commit changes to your branch
4) Push your work back up to your fork
5) Submit a pull request so that your changes can be reviewed

## License
Expression Evaluator for .NET source code is released under [MIT License](https://en.wikipedia.org/wiki/MIT_License).
