using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V24Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V24SubComponent> subComponents { get; internal set; }

        public HL7V24FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
