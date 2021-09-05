using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V25SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V25FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
