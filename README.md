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
  - [Reference](#reference)
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
  - [Examples](#examples)
  - [Roadmap](#roadmap)
  - [Contributing](#contributing)
  - [License](#license)

**Quick Links**
[Docs homepage](https://jmoceri34.github.io/expression-evaluator/index.html)
[Articles](https://jmoceri34.github.io/expression-evaluator/articles/ExpressionEvaluatorforDotNet.html)
[API Documentation](https://jmoceri34.github.io/expression-evaluator/api/index.html)
