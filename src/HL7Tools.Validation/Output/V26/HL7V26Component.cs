using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V26Component
    {
        public HL7V2Component component { get; init; }

        public IList<HL7V26SubComponent> subComponents { get; internal set; }

        public HL7V26FieldData fieldData { get; init; }

        public string Value { get { return component?.Value; } }
    }
}
