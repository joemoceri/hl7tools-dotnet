### HL7V2ExpressionConfiguration

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html)

Use this expression configuration for the [Evaluator](/api/ExpressionEvaluatorForDotNet.Evaluator.html) when parsing HL7V2 files.

Static Properties

- [fieldDelimiter](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_fieldDelimiter):
- [componentDelimiter]():
- [escapeDelimiter]():
- [subComponentDelimiter]():
- [fieldRepetitionDelimiter]():
- [presentButNull]():
- [specialSegmentHeaders]():
- [encodingConversions]():

When the static constructor is called, the encodingConversions are rebuilt using the current values of the static delimiters, and the specialSegmentHeaders are initialized. The default values are MSH, FHS, and BHS.

Every time Evaluate is called internally on an expression, this expression configuration calls an internal method named Setup that re-initializes the message segment. So each line of the hl7v2 message is an expression that the Evaluator converts into an HL7V2MessageSegment.

Static Methods

- [RebuildEncodingConversions]():
- [EncodeString]():
- [DecodeString]():

Inside of the constructor the operators and options are initialized. The SolveOperatorExpression callback for the AdditionOperator is where the main hl7v2 parsing takes place. It extracts the data from the hl7, applies structure via an HL7V2Field added to an HL7V2MessageSegment. After, it returns a DefaultExpressionResult, which can be found in ExpressionConfigurationBase.

Properties

- [MathStringOperators]():
- [BooleanOperators]():
- [Operators]():
- [Options]():

Methods

- [GetHL7V2MessageSegment]():
