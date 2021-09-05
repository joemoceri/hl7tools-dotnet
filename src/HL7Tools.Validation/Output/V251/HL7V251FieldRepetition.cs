using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V251FieldRepetition
    {
        public HL7V2FieldRepetition fieldRepetition { get; init; }

        public IList<HL7V251Component> components { get; internal set; }

        public HL7V251FieldData fieldData { get; init; }

        public string Value { get { return fieldRepetition?.Value; } }
    }
}
