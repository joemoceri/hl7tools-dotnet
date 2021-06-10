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
  - [Reference and Examples](#reference-and-examples)
    - [ExpressionConfigurationBase](#ExpressionConfigurationBase)
    - [CSharpExpressionConfiguration](#CSharpExpressionConfiguration)
    - [ExpressionConfigurationOperator](#ExpressionConfigurationOperator)
    - [ExpressionConfigurationOptions](#ExpressionConfigurationOptions)
    - [ExpressionGroup](#ExpressionGroup)
    - [ExpressionResult](#ExpressionResult)
    - [ExpressionType](#ExpressionType)
    - [ExpressionOperandTypes](#ExpressionOperandTypes)
    - [Operand](#Operand)
    - [Operator](#Operator)
    - [OperatorLocation](#OperatorLocation)
    - [OperatorPrecedence](#OperatorPrecedence)
    - [OperatorType](#OperatorType)
    - [VariableType](#VariableType)
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
This is a library written in C# .NET that will evaluate any math, string or boolean expression using built-in Expression Configurations. Expression Configurations are what the Evaluator uses when defining math, string, and boolean operators like '+', '-', '||', and so on. The operations are fully customizable. Using Expression Configurations you can hook into operator events before and after they're evaluated or evaluate the expression yourself with custom logic. The default expression configuration is C#. 

You can also use this to evaluate segments of an hl7v2 pipe delimited message. Using an HL7V2ExpressionConfiguration the Evaluator can be configured to parse and return a structured HL7V2Message object layered with fields, field repetitions, components, and subcomponents. You can also perform CRUD operations on all of them, build a message from scratch, and more.

### C# Expressions
For the C# Expression Configuration, if you try to [Evaluate](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/Evaluator/Evaluator.cs#L101) '1 > 2', it will return 'false', with a type of Boolean. You can hook into operators with the following methods: [OnBeforeOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L14) (before the expression is solved), [OnAfterOperatorExpressionSolved](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L15) (after the expression is solved), [SolveOperatorExpression](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationOperator.cs#L16) (override the default behavior and solve it yourself). You can also customize operators, such as changing '>' to 'greater-than' as an operator so that '1 greater-than 2' will return 'false' too. If any kind of error happens, the error is returned and the values are null. The result you get back after a call to Evaluate is a class called [ExpressionResult](https://github.com/jmoceri34/expression-evaluator/blob/6acb88b3da1c96aaf12e14cd9ca56f4a10eb5c22/src/Io.JoeMoceri.ExpressionEvaluator/Evaluator/ExpressionResult.cs#L8) that contains the value, variable type, and error, if any.

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
Expression Configurations are customizable settings you use to change the behavior of the Evaluator.

The default is [CSharpExpressionConfiguration](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/CSharp/CSharpExpressionConfiguration.cs) which inherits from [ExpressionConfigurationBase](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs). Using [HL7V2ExpressionConfiguration](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/HL7V2/HL7V2ExpressionConfiguration.cs) allows HL7V2 message parsing. To create your own Expression Configuration, inherit from ExpressionConfigurationBase.

## Reference and Examples

### ExpressionConfigurationBase

[Link to the file](https://github.com/jmoceri34/expression-evaluator/blob/master/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs)

Inherit from this class to create your own ExpressionConfiguration.

This exposes two virtual and two abstract properties:

- Virtual
  - [MathStringOperators](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs#L9): A list of ExpressionConfigurationOperator where their ExpressionOperatorType equals OperatorType.MathString.

  - [BooleanOperators](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs#L17): A list of ExpressionConfigurationOperator where their ExpressionOperatorType equals OperatorType.Boolean.

- Abstract
  - [Operators](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs#L25): A list of ExpressionConfigurationOperator.

  - [Options](https://github.com/jmoceri34/expression-evaluator/blob/2590c5a42411bf703fc8d36c10e991a4febba131/src/Io.JoeMoceri.ExpressionEvaluator/ExpressionConfigurations/ExpressionConfigurationBase.cs#L27): ExpressionConfigurationOptions.

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

### ExpressionConfigurationOperator

This is used inside of ExpressionConfigurations when defining the operators that should be used. A protected method on ExpressionConfigurationBase named CreateExpressionConfigurationOperator uses it to generate operators for ExpressionConfigurations. Please see inside each expression configuration for usage.

It exposes the following values

- ExpressionOperator: The Operator
- ExpressionOperatorPrecedence: The OperatorPrecedence
- ExpressionOperatorType: The OperatorType
- OperatorName: The name of the operator (+, -, %, /, so on)
- OnBeforeOperatorExpressionSolved: An action you can hook into to invoke before an operator (inner) expression is solved.
- OnAfterOperatorExpressionSolved: An action you can hook into to invoke after an operator (inner) expression is solved.
- SolveOperatorExpression: A Func you can hook into to invoke and override solving an operator (inner) expression.

### ExpressionConfigurationOptions

These are the options used to customize ExpressionConfigurations. 

It exposes three properties

- IgnoreWhitespaceOutsideQuotes: Whether whitespace outside of quotes inside the expression should be ignored.

- IgnoreParentheses: Whether parentheses inside the expression should be ignored.

- IgnoreQuotesValidation: Whether quote validation inside the expression should be ignored.

### ExpressionGroup

This is passed inside SolveOperatorExpression. It exposes four properties:

- LeftOperand: The left operand of the expression (1 of 1+2)
- RightOperand: The right operand of the expression (2 of 1+2)
- ExpressionOperator: The Operator of the expression (Addition, Subtraction, and so forth)
- ExpressionType: The ExpressionType of the expression (Math, String, or Boolean)

### ExpressionResult

This is the object you get back when you call Evaluate. It exposes the following three properties

- Value: The resulting value after evaluating the expression, represented as a string.
- Type: The VariableType of the Value.
- Error: An Exception containing the error. This is null if the result is successful.

The following three methods are overridden

- ToString: Returns the Value
- Equals: Compares two expression results using the Value and Type for equality
- GetHashCode: Generates a unique hash code

### ExpressionType

An enumeration used internally for specifying the type of an expression (Math, String, or Boolean)

### ExpressionOperandTypes

A class used internally for identifying types for an expression. Three properties are exposed

- LeftOperandType: The ExpressionType of the left operand of the expression
- RightOperandType: The ExpressionType of the right operand of the expression
- ExpressionType: The ExpressionType of the expression

### Operand

A class used internally for describing an Operand's Value and Type of an expression. Two properties are exposed.

- Value: A string representing the operand of the expression
- Type: The VariableType of the operand of the expression

### Operator

An enumeration for the available operators used in the ExpressionConfigurations

### OperatorLocation

A class used internally inside the Evaluator for keeping track of which inner expression to evaluate next. Two properties are exposed

- Value: The Value at the Index
- Index: The index of the Operator. If null, there are no more expressions to evaluate

### OperatorPrecedence

An enumeration that defines the different levels of precedence for operations. Options are Higher and Lower.

### OperatorType

An enumeration for defining operator types. Options are MathString and Boolean.

### VariableType

An enumeration for variable types of results of expressions. Options are Boolean, Int, Float, and String.

### HL7V2ExpressionConfiguration

Use this ExpressionConfiguration for the Evaluator when parsing HL7V2 files.

There are eight static properties exposed

- fieldDelimiter:
- componentDelimiter:
- escapeDelimiter:
- subComponentDelimiter:
- fieldRepetitionDelimiter:
- presentButNull:
- specialSegmentHeaders:
- encodingConversions:

When the static constructor is called, the encodingConversions are rebuilt using the current values of the static delimiters, and the specialSegmentHeaders are initialized. The default values are MSH, FHS, and BHS.

Every time Evaluate is called internally on an expression, this expression configuration calls an internal method named Setup that re-initializes the message segment. So each line of the hl7v2 message is an expression that the Evaluator converts into an HL7V2MessageSegment.

Three static methods are exposed

- RebuildEncodingConversions:
- EncodeString:
- DecodeString:

Inside of the constructor the operators and options are initialized. The SolveOperatorExpression callback for the AdditionOperator is where the main hl7v2 parsing takes place. It extracts the data from the hl7, applies structure via an HL7V2Field added to an HL7V2MessageSegment. After, it returns a DefaultExpressionResult, which can be found in ExpressionConfigurationBase.

The following four properties are exposed

- MathStringOperators:
- BooleanOperators:
- Operators:
- Options:

The following method is exposed

- GetHL7V2MessageSegment:

### HL7V2Message

### HL7V2MessageSegment

### HL7V2FieldBase

### HL7V2Field

### HL7V2FieldRepetition

### HL7V2Component

### HL7V2SubComponent

## Roadmap
* Version objects for HL7
* MLLP for HL7
* JSON support for HL7
* XML support for HL7
* Validation for HL7
* ACK and NACK for HL7
* V3 support for HL7
* FHIR support for HL7
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
