### ExpressionResult

**Table of Contents**
- [Description](#description)
- [Properties](#properties)
- [Methods](#methods)
- [Links](#links)

#### Description

This is the object you get back when you call [Evaluate](../api/HL7Tools.Evaluator.html#HL7Tools_Evaluator_Evaluate_System_String_). 

#### Properties

- [Value](../api/HL7Tools.ExpressionResult.html#HL7Tools_ExpressionResult_Value): The resulting value after evaluating the expression, represented as a string.
- [Type](../api/HL7Tools.ExpressionResult.html#HL7Tools_ExpressionResult_Type): The VariableType of the Value.
- [Error](../api/HL7Tools.ExpressionResult.html#HL7Tools_ExpressionResult_Error): An Exception containing the error. This is null if the result is successful.

#### Methods

- [ToString](../api/HL7Tools.ExpressionResult.html#HL7Tools_ExpressionResult_ToString): Returns the Value.
- [Equals](../api/HL7Tools.ExpressionResult.html#HL7Tools_ExpressionResult_Equals_System_Object_): Compares two expression results using the Value and Type for equality.
- [GetHashCode](../api/HL7Tools.ExpressionResult.html#HL7Tools_ExpressionResult_GetHashCode): Generates a unique hash code

#### Links

[Link to the file](../api/HL7Tools.ExpressionResult.html)