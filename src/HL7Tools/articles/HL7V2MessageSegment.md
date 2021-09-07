### HL7V2MessageSegment

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Methods](#methods)
- [Links](#links)

#### Description

Message segments are defined in hl7 v2 specification. They contain fields, and each field outside of special cases, contains 1 field repetition. The crud operations make sure to handle this. Special cases, such as MSH.1 and MSH.2, do not have a field repetition, while MSH.5 does.

The structure of message segments is as follows

Field -> FieldRepetition -> Components -> Sub Components

#### Properties

- [SegmentName](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_SegmentName): The name of the segment.
- [Fields](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_Fields): The fields within the segment. 

#### Methods

- [ToString](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_ToString): Converts the message segment to a string using the Values of it's fields.
- [Rebuild](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_Rebuild): Rebuilds the values of each of the message segments fields.
- [GetField](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_GetField_System_Int32_): Gets a field by Id.
- [AddField](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_AddField_System_String_System_Boolean_): Adds a field to end of the message segment.
- [RemoveField](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_RemoveField_System_Int32_): Removes a field by Id from the message segment.
- [InsertField](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_InsertField_System_Int32_System_String_): Inserts a field by Id into the message segment.
- [UpdateField](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_UpdateField_System_Int32_System_String_): Updates a field by Id in the message segment.

An [indexer](../api/HL7Tools.HL7V2MessageSegment.html#HL7Tools_HL7V2MessageSegment_Item_System_Int32_) is exposed to access fields by their Id.

#### Links

[Link to the file](../api/HL7Tools.HL7V2MessageSegment.html)