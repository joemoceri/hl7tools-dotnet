using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V25Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V25SubComponent> subComponents { get; internal set; }

        public HL7V25FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
