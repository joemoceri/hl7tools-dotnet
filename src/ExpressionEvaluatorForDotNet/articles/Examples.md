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

Given an HL7V2Message like below (ADT_A08 from the hl7 confluence wiki)

```csharp
// you need this configuration to evaluate hl7v2 files
var expressionConfiguration = new HL7V2ExpressionConfiguration();

// pass it into the evaluator
var evaluator = new Evaluator(expressionConfiguration);

// call this method on a file path to get the HL7V2Message object
var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

// this will be null if the message was evaluated successfully
var error = message.Error;

// you can access message segments
var messageSegments = message.MessageSegments;

// get all of the message segments named MSH
var mshMessageSegments = message.Segments("MSH");

// get the MSH message segment by indexer
var msh = message["MSH"];

// optionally you can pass in index in case of multiple (default is 0)
msh = message["MSH", 0];

// Get using various methods. This always returns HL7V2FieldBase, you can cast to HL7V2Field or others depending on what you need.
// Get the first index MSH's' 1st field (MSH.1)
var msh1 = message.Get("MSH.1");

msh1 = message["MSH"][1];

// Get the first index PIDs 5th field 1st component
var pid51 = message.Get("PID.5.1");
pid51 = message["PID"][5][1];

// the first index of the segment (0) returns that message segment. Default is 0.
pid51 = message.Get("PID(1).5.1");

// Get the first index GT1's 6th fields 2nd repetitions 1st component
var gt1621 = message.Get("GT1.6(2).1");
.Value, message["GT1"][6][1, 2].Value);

// evaluate a new message
message = evaluator.EvaluateHL7V2File("ADT-A05 Pre-admit Patient.txt");

// Get the first index PD1's 4th fields 9th components 2nd sub component
var pid1492 = message.Get("PD1.4.9.2");
pid1492 = message["PD1"][4][9][2];

// The following calls will result in a null return value
var bad = message.Get("INVALID");

bad = message.Get("....");

bad = message.Get("a.ba.c.d");

bad = message.Get(".a.ba.c.d");

bad = message.Get("a.ba.c.d.");

bad = message.Get(null);

bad = message.Get(string.Empty);

// Add message segment. This will add it to the end of the message. The message segment is returned when added.
var obr = message.AddMessageSegment("OBR");

// Remove message segment. The return value will tell you if it was successful.
var removed = message.RemoveMessageSegment("OBR");

// If you try to remove a segment that doesn't exist, it will return false.
removed = message.RemoveMessageSegment("NOPE");

// Insert a message segment by Id. Returns the message segment inserted. By default inserts at the beginning (index 0).
var frontObr = message.InsertMessageSegment("OBR");

// can't do this, will return null
frontObr = message.InsertMessageSegment("OBR", -1);

// Insert message segment at index.
var index = message.MessageSegments.Count / 2;

obr = message.InsertMessageSegment("OBR", index);

// You can convert it to a string array by calling ToHL7V2MessageFile
var messageToFile = message.ToHL7V2MessageFile();

// or to a string
var messageToString = message.ToString();

// When modifying a field (CRUD operation), make sure to call Rebuild after to update the Value
var msh9 = ((HL7V2Field)message.Get("MSH.9"));

msh9.AddComponent("_test");

// not equal before
// message.ToString() != joinedMessageFile

message.Rebuild();

// after rebuilding, they're now equal
// // message.ToString() == joinedMessageFile
```

#### HL7V2MessageSegments

#### HL7V2Fields

#### HL7V2FieldRepetitions

#### HL7V2Components

#### HL7V2SubComponents
