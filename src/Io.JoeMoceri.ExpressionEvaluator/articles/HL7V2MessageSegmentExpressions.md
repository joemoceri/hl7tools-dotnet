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
