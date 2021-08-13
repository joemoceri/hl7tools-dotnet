using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V28FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
