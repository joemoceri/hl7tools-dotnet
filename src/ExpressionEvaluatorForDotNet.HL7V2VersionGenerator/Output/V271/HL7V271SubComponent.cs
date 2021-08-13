using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V271FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
