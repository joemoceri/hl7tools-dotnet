### Examples

**Table of Contents**
- [Description](#description)
- [CSharp Expressions](#csharp-expressions)
- [HL7V2Messages](#hl7v2messages)
- [HL7V2MessageSegments](#hl7v2messagesegments)
- [HL7V2Fields](#hl7v2fields)
- [HL7V2FieldRepetitions](#hl7v2fieldrepetitions)
- [HL7V2Components](#hl7v2components)
- [HL7V2SubComponents](#hl7v2subcomponents)

#### Description

See examples below for how to work with each object.

To see these in action, check out the [Tests Project](https://github.com/joemoceri/expression-evaluator-dotnet/tree/main/src/ExpressionEvaluatorForDotNet.Tests) and [Sample Project](https://github.com/joemoceri/expression-evaluator-dotnet/tree/main/src/ExpressionEvaluatorForDotNet.Sample).

#### CSharp Expressions

Solve a math expression.

```csharp
public void SolveMathExample()
{
    var evaluator = new Evaluator();

    var r = 1 + 2 * (3 - 4) / 18;

    var result = evaluator.Evaluate("1 + 2 * (3 - 4) / 18");

    Console.WriteLine($"{r} = {result}");
}
```

Solve a string expression.

```csharp
public void SolveStringExample()
{
    var evaluator = new Evaluator();

    var r = "\" ab + " + " cd \"";
    var expression = " \" ab + \" + \" cd \"";

    var result = evaluator.Evaluate(expression);

    Console.WriteLine($"{r} = {result}");
}
```

Solve a boolean expression.

```csharp
public void SolveBooleanExample()
{
    var evaluator = new Evaluator();

    var r = 1 > 2 && (3 + 4) / 2 == 5;

    var result = evaluator.Evaluate("1 > 2 && (3 + 4) / 2 == 5");

    Console.WriteLine($"{r} = {result}");
}
```

#### HL7V2Messages

#### HL7V2MessageSegments

#### HL7V2Fields

#### HL7V2FieldRepetitions

#### HL7V2Components

#### HL7V2SubComponents
