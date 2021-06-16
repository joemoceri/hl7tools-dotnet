### HL7V2Field

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Methods](#methods)
- [Links](#links)

#### Description

Fields are defined in hl7 v2 specification. By default they contain a single field repetition to represent the field, outside of special cases, such as the first two fields of any special segment headers (MSH.1 and MSH.2). There are CRUD operations you can perform on components and field repetitions. Field repetitions and components are both by Id, with components defaulting to the first field repetition. 

#### Properties

- [Id](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_Id): The position of the field.
- [Delimiter](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_Delimiter): The delimiter used when generating the value when calling Rebuild.
- [Value](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_Value): The value of the field.
- [FieldRepetitions](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_FieldRepetitions): The field repetitions, if any.

#### Methods

- [GetFieldRepetition](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_GetFieldRepetition_System_Int32_): Gets a field repetition by Id.
- [Components](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_Components_System_Int32_): Gets this fields components by field repetition Id.
- [GetComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_GetComponent_System_Int32_System_Int32_): Gets this fields components by field repetition Id.
- [Rebuild](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_Rebuild): Rebuilds the Value on this field.
- [AddComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_AddComponent_System_String_System_Int32_): Adds a component to the end of this field by field repetition Id.
- [RemoveComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_RemoveComponent_System_Int32_System_Int32_): Removes a component from this field by Id and field repetition Id.
- [InsertComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_InsertComponent_System_Int32_System_String_System_Int32_): Inserts a component into this field by Id and field repetition Id.
- [UpdateComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_UpdateComponent_System_Int32_System_String_System_Int32_): Updates a component in this field by Id and field repetition Id.
- [AddFieldRepetition](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_AddFieldRepetition_System_String_): Adds a field repetition to the end of the field.
- [RemoveFieldRepetition](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_RemoveFieldRepetition_System_Int32_): Removes a field repetition from the field by Id.
- [InsertFieldRepetition](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_InsertFieldRepetition_System_Int32_System_String_): Inserts a field repetition by Id into the field.
- [UpdateFieldRepetition](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_UpdateFieldRepetition_System_Int32_System_String_): Updates a field repetition by Id in the field.

An [indexer](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html#ExpressionEvaluatorForDotNet_HL7V2Field_Item_System_Int32_System_Int32_) is exposed to access this field's HL7V2Components by their Ids and repetition (default is 1).

#### Links

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2Field.html)