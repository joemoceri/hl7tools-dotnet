using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V22FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
