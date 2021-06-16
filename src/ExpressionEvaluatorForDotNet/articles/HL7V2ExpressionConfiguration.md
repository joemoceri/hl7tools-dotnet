### HL7V2ExpressionConfiguration

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html)

Use this expression configuration for the [Evaluator](/api/ExpressionEvaluatorForDotNet.Evaluator.html) when parsing HL7V2 files.

When the static constructor is called, the encodingConversions are rebuilt using the current values of the static delimiters, and the specialSegmentHeaders are initialized. The default values are MSH, FHS, and BHS.

Every time Evaluate is called internally on an expression, this expression configuration calls an internal method named Setup that re-initializes the message segment. So each line of the hl7v2 message is an expression that the Evaluator converts into an HL7V2MessageSegment.

Inside of the constructor the operators and options are initialized. The SolveOperatorExpression callback for the AdditionOperator is where the main hl7v2 parsing takes place. It extracts the data from the hl7, applies structure via an HL7V2Field added to an HL7V2MessageSegment. After, it returns a DefaultExpressionResult, which can be found in ExpressionConfigurationBase.

Static Fields

- [fieldDelimiter](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_fieldDelimiter): This separates fields in an hl7v2 message segment.
- [componentDelimiter](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_componentDelimiter): This separates components within a field repetition in an hl7v2 message segment. This is defined within special segments, such as MSH.
- [escapeDelimiter](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_escapeCharacter): This is used to encode / decode data within hl7v2 messages. This is defined within special segments, such as MSH.
- [subComponentDelimiter](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_subComponentDelimiter): This separates sub components within components in an hl7v2 message segment. This is defined within special segments, such as MSH.
- [fieldRepetitionDelimiter](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_fieldRepetitionDelimiter): This separates field repetitions within fields in an hl7v2 message segment. This is defined within special segments, such as MSH.
- [presentButNull](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_presentButNull): This string is used to define data that should be treated as null as specified in the hl7 v2 specification.
- [specialSegmentHeaders](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_specialSegmentHeaders): These segment headers should be treated separately from other segments because they expose the delimiters that the message should use when evaluating the segment.
- [encodingConversions](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_encodingConversions): Encoding conversions are used to encode / decode data for hl7 data using the delimiters wrapped around the escape character.

Static Methods

- [RebuildEncodingConversions](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_RebuildEncodingConversions): This rebuilds the encodingConversions so that when EncodeString or DecodeString is called it uses the latest values from the delimiters and escape character. Make sure to call this if you update any of the delimiters or escape characters before calling EncodeString or DecodeString.
- [EncodeString](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_EncodeString_System_String_): Encodes a string for use in an hl7 v2 message using the delimiters wrapped around the escape character.
- [DecodeString](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_DecodeString_System_String_): Decodes a string for use in an hl7 v2 message using the delimiters wrapped around the escape character.

Properties

- [Operators](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_Operators): The operators. Only Addition as '|' is used.
- [Options](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_Options): The options.

```csharp
            options = new ExpressionConfigurationOptions
            {
                IgnoreWhitespaceOutsideQuotes = true,
                IgnoreParentheses = true,
                IgnoreQuotesValidation = true
            };
```

Methods

- [GetHL7V2MessageSegment](/api/ExpressionEvaluatorForDotNet.HL7V2ExpressionConfiguration.html#ExpressionEvaluatorForDotNet_HL7V2ExpressionConfiguration_GetHL7V2MessageSegment): Returns the message segment. Called internally when evaluating an hl7v2 file to build the hl7v2 message.
