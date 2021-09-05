using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V26SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V26FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
