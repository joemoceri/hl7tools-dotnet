### HL7V2Component

[Link to the file](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html)

Description

Components are defined in hl7v2 specification. They can contain sub components and exist within field repetitions.

Properties

- [Id](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_Id): The position of the component.
- [Delimiter](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_Delimiter): The delimiter of the component.
- [Value](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_Value): The value of the component.
- [SubComponents](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_SubComponents): The sub components of the component.

Methods

- [GetSubComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_GetSubComponent_System_Int32_): Gets a sub component by Id.
- [Rebuild](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_Rebuild): Rebuilds this components Value.
- [AddSubComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_AddSubComponent_System_String_): Adds a sub component to the end of the component.
- [RemoveSubComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_RemoveSubComponent_System_Int32_): Removes a sub component by Id.
- [InsertSubComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_InsertSubComponent_System_Int32_System_String_): Inserts a sub component by Id.
- [UpdateSubComponent](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_UpdateSubComponent_System_Int32_System_String_): Updates a sub component by Id.

An [indexer](/api/ExpressionEvaluatorForDotNet.HL7V2Component.html#ExpressionEvaluatorForDotNet_HL7V2Component_Item_System_Int32_) is exposed to allow access to this components HL7V2SubComponents.
