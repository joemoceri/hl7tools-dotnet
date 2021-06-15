### HL7V2FieldBase

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2FieldBase.html)

This is an abstract base class that all 'field' type objects inherit from. This includes the following: HL7V2Field, HL7V2FieldRepetition, HL7V2Component, and HL7V2SubComponent.

The following three abstract properties must be implemented

- Id:
- Delimiter:
- Value:

The following method must be implemented

- Rebuild:

One protected method is exposed

- CombineHL7Fields:
