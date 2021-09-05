using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V251SubComponent
    {
        public HL7V2SubComponent subComponent { get; init; }

        public HL7V251FieldData fieldData { get; init; }

        public string Value { get { return subComponent.Value; } }
    }
}
