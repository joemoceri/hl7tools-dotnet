using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V25FieldRepetition
    {
        public HL7V2FieldRepetition fieldRepetition { get; init; }

        public IList<HL7V25Component> components { get; internal set; }

        public HL7V25FieldData fieldData { get; init; }

        public string Value { get { return fieldRepetition?.Value; } }
    }
}
