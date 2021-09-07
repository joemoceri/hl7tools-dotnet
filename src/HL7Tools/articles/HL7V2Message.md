### HL7V2Message

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Methods](#methods)
- [Links](#links)

#### Description

Messages are defined in the v2 specification. They contain message segments, such as MSH, PV1, OBR, and more. You can perform CRUD operations on the message segments by Index. Rebuild the message after making changes to its message segments.

#### Properties

- [MessageSegments](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_MessageSegments): The message segments.
- [Error](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_Error): The error. This will be null if the resulting Message parsed by the Evalutor is successful.

#### Methods

- [Rebuild](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_Rebuild): Rebuilds the message by calling Rebuild on the message segments to update all values. Rebuild the message if you make many changes on it's fields at the end.
- [Get](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_Get_System_String_): Gets a field, field repetition, component, or sub component by a string-based id.
- [Segments](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_Segments_System_String_): The segments, optionally by segmentName to return a list of message segments in case of multiple.
- [ToHL7V2MessageFile](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_ToHL7V2MessageFile): Converts the hl7v2 message to an ordered array of strings.
- [ToString](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_ToString): Converts the hl7v2 message to a string joined by the current environments representation of a new line character.
- [AddMessageSegment](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_AddMessageSegment_System_String_): Adds a message segment to the end of the current list of messageSegments.
- [RemoveMessageSegment](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_RemoveMessageSegment_System_String_System_Int32_): Removes a message segment by Id from the current list of messageSegments.
- [InsertMessageSegment](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_InsertMessageSegment_System_String_System_Int32_): Inserts a message segment by Id into the current list of messageSegments.
- [Equals](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_Equals_System_Object_): Compares two messages by their string values and hash code.
- [GetHashCode](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_GetHashCode): Generates a unique hash code off of the message.

An [indexer](../api/HL7Tools.HL7V2Message.html#HL7Tools_HL7V2Message_Item_System_String_System_Int32_) is exposed, to access segments by segmentName and optionally, by index in case of multiple.


#### Links

[Link to the file](../api/HL7Tools.HL7V2Message.html)