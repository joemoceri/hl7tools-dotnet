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
gt1621 = message["GT1"][6][1, 2].Value);

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

Given an HL7V2Message like below (ADT_A08 from the hl7 confluence wiki)

```csharp
var expressionConfiguration = new HL7V2ExpressionConfiguration();

var evaluator = new Evaluator(expressionConfiguration);

var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

// get the MSH segment
var msh = message["MSH"];

var value = $"{Guid.NewGuid()}";

// You can update fields. It returns the field if successful
var field = msh.UpdateField(2, value);

// if the id doesn't exist (0 or msh.Fields.Count), field will be null
field = msh.UpdateField(0, value);

field = msh.UpdateField(msh.Fields.Count, value);

// insert field
var id = msh.Fields.Count / 2;
field = msh.InsertField(id, "_test");

field = msh.InsertField(msh.Fields.Count, "_test");

// remove field
var removed = msh.RemoveField(id);

// returns false if it didn't remove the field
removed = msh.RemoveField(0);

// add field. Adds it to the end of the fields
value = $"{Guid.NewGuid()}";

field = msh.AddField(value);

// get field
field = msh.GetField(5);

// returns null if it doesn't exist
field = msh.GetField(0);

field = msh[0];

// to string
var messageSegmentToString = msh.ToString();

// make sure to rebuild when performing CRUD operations
value = $"{Guid.NewGuid()}";

msh[9].AddComponent(value);

msh.Rebuild();
```

#### HL7V2Fields

Given an HL7V2Message like below (ADT_A08 from the hl7 confluence wiki)

```csharp
var expressionConfiguration = new HL7V2ExpressionConfiguration();

var evaluator = new Evaluator(expressionConfiguration);

var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

// get gt16 and cast as a HL7V2Field
var gt16 = (HL7V2Field)message.Get("GT1.6");

// this will be the field delimiter
var delimiter = gt16.Delimiter;

// get field repetition
var frSplit = gt16.Value.Split(HL7V2ExpressionConfiguration.fieldRepetitionDelimiter);

// get gt16s 1st field repetition
var gt161 = gt16.GetFieldRepetition(1);

// trying to get a nonexistent field repetition results in a null return value
var fr = gt16.GetFieldRepetition(0);

// Rebuild when performing CRUD operations
var value = $"{Guid.NewGuid()}";

var oldValue = gt16.Value;

// add a field repetition
gt16.AddFieldRepetition(value);

// gt16.Value == oldValue

gt16.Rebuild();

// gt16.Value != oldValue

// get a the first component on gt16 field
var c = gt16.Components()[0];
c = gt16[1];
c = gt16.GetComponent(1);

// will return null if nonexistent
c = gt16.Components(0);
c = gt16.GetComponent(0);

// add component to the end of the components list on this field. By default chooses the 1st field repetition (every field outside of special cases always has at least 1 field repetition)
var component = gt16.AddComponent("_test");

// invalid id will result in null return value
component = gt16.AddComponent("_test", 0);

// add component by repetition
component = gt16.AddComponent("_test", 2);

// remove component by Id. Will return true if successful
var removed = gt16.RemoveComponent(gt16.Components().Count);

// invalid ids result in false
removed = gt16.RemoveComponent(1, 0);
removed = gt16.RemoveComponent(0, 1);

// remove component by repetition
previousCount = gt16.Components(2).Count;
removed = gt16.RemoveComponent(gt16.Components(2).Count, 2);

// insert component

var id = gt16.Components().Count / 2;
previousCount = gt16.Components().Count;
component = gt16.InsertComponent(id, "_test");

// invalid inserts result in null return value
component = gt16.InsertComponent(0, "_test", 1);
component = gt16.InsertComponent(1, "_test", 0);

// insert component by repetition (2)
id = gt16.Components(2).Count / 2;
previousCount = gt16.Components(2).Count;
component = gt16.InsertComponent(id, "_test", 2);

// update component 
component = gt16.UpdateComponent(1, "_test");

// invalid updates result in null return
component = gt16.UpdateComponent(0, "_test", 1);
component = gt16.UpdateComponent(1, "_test", 0);

// update component by repetition
component = gt16.UpdateComponent(1, "_test", 2);

// add field repetition
previousCount = gt16.FieldRepetitions.Count;
var fieldRepetition = gt16.AddFieldRepetition("_test");

// remove field repetition
removed = gt16.RemoveFieldRepetition(fieldRepetition.Id);

// invalid removes result in false return
removed = gt16.RemoveFieldRepetition(0);

// insert field repetition
id = gt16.FieldRepetitions.Count / 2;
previousCount = gt16.FieldRepetitions.Count;
fieldRepetition = gt16.InsertFieldRepetition(id, "_test");

// invalid inserts result in null return values
fieldRepetition = gt16.InsertFieldRepetition(0, null);
fieldRepetition = gt16.InsertFieldRepetition(gt16.FieldRepetitions.Count + 1, "_test");

// update field repetition
fieldRepetition = gt16.UpdateFieldRepetition(2, "_test");

// bad updates result in null return values
fieldRepetition = gt16.UpdateFieldRepetition(0, "_test");
fieldRepetition = gt16.UpdateFieldRepetition(gt16.FieldRepetitions.Count, "_test");

// when you add components, it will add sub components for you if you include the delimiters
component = gt16.AddComponent("1&2&3");

// 3
var count = component.SubComponents.Count;
```

#### HL7V2FieldRepetitions

Given an HL7V2Message like below (ADT_A08 from the hl7 confluence wiki)

```csharp
var expressionConfiguration = new HL7V2ExpressionConfiguration();

var evaluator = new Evaluator(expressionConfiguration);

var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

// get this field repetition
var gt161 = (HL7V2FieldRepetition)message.Get("GT1.6(1)");

// this is the field repetitions delimiter
var delimiter = gt161.Delimiter;

// get component by Id
var component = gt161.GetComponent(1);

// add component to the end of the field repetitions components
component = gt161.AddComponent("_test");

// remove component by Id
var removed = gt161.RemoveComponent(component.Id);

// will return false if not successful
removed = gt161.RemoveComponent(0);

// insert component
var id = gt161.Components.Count / 2;
component = gt161.InsertComponent(id, "_test");

// invalid inserts result in null return values
component = gt161.InsertComponent(0, "_test");
component = gt161.InsertComponent(gt161.Components.Count + 1, "_test");

// update component
component = gt161.UpdateComponent(1, "_test");

// invalid inserts result in null return value
component = gt161.UpdateComponent(0, "_test");
component = gt161.UpdateComponent(gt161.Components.Count + 1, "_test");

```

#### HL7V2Components

Given an HL7V2Message like below (ADT_A08 from the hl7 confluence wiki)

```csharp
var expressionConfiguration = new HL7V2ExpressionConfiguration();

var evaluator = new Evaluator(expressionConfiguration);

var message = evaluator.EvaluateHL7V2File("ADT-A08 Update Patient.txt");

// get pv179 component
var pv179 = (HL7V2Component)message.Get("PV1.7.9");

var delimiter = pv179.Delimiter;

// add sub component to the end of SubComponents
var previousCount = pv179.SubComponents.Count;
var subComponent = pv179.AddSubComponent("_test");

// will return null if it can't get the sub component
var testSubComponent = pv179.GetSubComponent(0);
testSubComponent = pv179[0];

// remove sub component by Id
var removed = pv179.RemoveSubComponent(subComponent.Id);

// invalid removes result in false
removed = pv179.RemoveSubComponent(0);

// insert sub component
var id = pv179.SubComponents.Count / 2;
subComponent = pv179.InsertSubComponent(id, "_test");

// invalid inserts result in null return value
subComponent = pv179.InsertSubComponent(0, "_test");
subComponent = pv179.InsertSubComponent(pv179.SubComponents.Count + 1, "_test");

// update sub component
subComponent = pv179.UpdateSubComponent(1, "_test");

// invalid updates result in null return value
subComponent = pv179.UpdateSubComponent(0, "_test");
subComponent = pv179.UpdateSubComponent(pv179.SubComponents.Count + 1, "_test");
```

#### HL7V2SubComponents

Given an HL7V2Message like below (ADT_A05 from the hl7 confluence wiki)

```csharp
// you need this configuration to evaluate hl7v2 files
var expressionConfiguration = new HL7V2ExpressionConfiguration();

// pass it into the evaluator
var evaluator = new Evaluator(expressionConfiguration);

// evaluate a new message
message = evaluator.EvaluateHL7V2File("ADT-A05 Pre-admit Patient.txt");

// Get the first index PD1's 4th fields 9th components 2nd sub component
// Sub components have Id, Value, Delimiter, and Rebuild. Rebuild does nothing.
var pid1492 = message.Get("PD1.4.9.2");
pid1492 = message["PD1"][4][9][2];

```
