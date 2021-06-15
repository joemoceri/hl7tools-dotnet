### HL7V2ExpressionConfiguration

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html)

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
