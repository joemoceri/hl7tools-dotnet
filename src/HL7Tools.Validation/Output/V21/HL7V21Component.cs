using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V21Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V21SubComponent> subComponents { get; internal set; }

        public HL7V21FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
