using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V251FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
