### HL7V2MessageSegment

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html)

Description

Message segments are defined in hl7 v2 specification. They contain fields, and each field outside of special cases, contains 1 field repetition. The crud operations make sure to handle this. Special cases, such as MSH.1 and MSH.2, do not have a field repetition, while MSH.5 does.

Properties

- [SegmentName](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_SegmentName): The name of the segment.
- [Fields](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_Fields): The fields within the segment. 

Methods

- [ToString](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_ToString): Converts the message segment to a string using the Values of it's fields.
- [Rebuild](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_Rebuild): Rebuilds the values of each of the message segments fields.
- [GetField](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_GetField_System_Int32_): Gets a field by Id.
- [AddField](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_AddField_System_String_System_Boolean_): Adds a field to end of the message segment.
- [RemoveField](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_RemoveField_System_Int32_): Removes a field by Id from the message segment.
- [InsertField](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_InsertField_System_Int32_System_String_): Inserts a field by Id into the message segment.
- [UpdateField](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_UpdateField_System_Int32_System_String_): Updates a field by Id in the message segment.

An [indexer](/api/ExpressionEvaluatorForDotNet.HL7V2MessageSegment.html#ExpressionEvaluatorForDotNet_HL7V2MessageSegment_Item_System_Int32_) is exposed to access fields by their Id.
