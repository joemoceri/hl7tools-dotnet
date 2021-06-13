### ExpressionResult

This is the object you get back when you call Evaluate. It exposes the following three properties

- Value: The resulting value after evaluating the expression, represented as a string.
- Type: The VariableType of the Value.
- Error: An Exception containing the error. This is null if the result is successful.

The following three methods are overridden

- ToString: Returns the Value
- Equals: Compares two expression results using the Value and Type for equality
- GetHashCode: Generates a unique hash code
