### HL7V2FieldBase

**Table of Contents**
- [Description](#description)
- [Abstract Properties](#abstract-properties)
- [Abstract Methods](#abstract-methods)
- [Protected Methods](#protected-methods)
- [Links](#links)

#### Description

This is an abstract base class that all 'field' type objects inherit from. This includes the following: HL7V2Field, HL7V2FieldRepetition, HL7V2Component, and HL7V2SubComponent.

#### Abstract Properties

- [Id](../api/HL7Tools.HL7V2FieldBase.html#HL7Tools_HL7V2FieldBase_Id): The position of the field.
- [Delimiter](../api/HL7Tools.HL7V2FieldBase.html#HL7Tools_HL7V2FieldBase_Delimiter): The delimiter for the type of field.
- [Value](../api/HL7Tools.HL7V2FieldBase.html#HL7Tools_HL7V2FieldBase_Value): The value of the field.

#### Abstract Methods

- [Rebuild](../api/HL7Tools.HL7V2FieldBase.html#HL7Tools_HL7V2FieldBase_Rebuild): Rebuild should update the Value of the field if necessary (sub components rebuild does nothing).

#### Protected Methods

- [CombineHL7Fields](../api/HL7Tools.HL7V2FieldBase.html#HL7Tools_HL7V2FieldBase_CombineHL7Fields_System_Collections_Generic_IList_HL7Tools_HL7V2FieldBase__): Used within the Rebuild methods to update the Values.

#### Links

[Link to the file](../api/HL7Tools.HL7V2FieldBase.html)