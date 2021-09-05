using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V26FieldRepetition
    {
        public HL7V2FieldRepetition fieldRepetition { get; init; }

        public IList<HL7V26Component> components { get; internal set; }

        public HL7V26FieldData fieldData { get; init; }

        public string Value { get { return fieldRepetition?.Value; } }
    }
}
