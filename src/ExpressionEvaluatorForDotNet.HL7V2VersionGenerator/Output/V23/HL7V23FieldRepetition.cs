using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23FieldRepetition
    {
        public HL7V2FieldRepetition fieldRepetition { get; init; }

        public IList<HL7V23Component> components { get; internal set; }

        public HL7V23FieldData fieldData { get; init; }

        public string Value { get { return fieldRepetition?.Value; } }
    }
}
