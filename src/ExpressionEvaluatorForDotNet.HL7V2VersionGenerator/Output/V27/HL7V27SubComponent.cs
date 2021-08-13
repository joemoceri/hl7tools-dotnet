using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V27FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
