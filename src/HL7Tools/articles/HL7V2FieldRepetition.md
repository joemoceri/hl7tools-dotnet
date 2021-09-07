### HL7V2FieldRepetition

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Methods](#methods)
- [Links](#links)

#### Description

Field repetitions are defined in hl7 v2 specification. They exist within fields, outside of special cases such as MSH.1 and MSH.2. Field repetitions contain components.

#### Properties

- [Id](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_Id): The position of the field repetition.
- [Delimiter](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_Delimiter): The delimiter of the field repetition.
- [Value](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_Value): The value of the field repetition.
- [Components](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_Components): The components on the field repetition.

#### Methods

- [Rebuild](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_Rebuild): Rebuilds the value of this field repetition.
- [AddComponent](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_AddComponent_System_String_): Adds a component to the end of the field repetition.
- [RemoveComponent](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_RemoveComponent_System_Int32_): Removes a component by Id from the field repetition.
- [InsertComponent](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_InsertComponent_System_Int32_System_String_): Inserts a component by Id into the field repetition.
- [UpdateComponent](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_UpdateComponent_System_Int32_System_String_): Updates a component by Id in the field repetition.

An [indexer](../api/HL7Tools.HL7V2FieldRepetition.html#HL7Tools_HL7V2FieldRepetition_Item_System_Int32_) is exposed to allow access to this field repetitions HL7V2Components.

#### Links

[Link to the file](../api/HL7Tools.HL7V2FieldRepetition.html)