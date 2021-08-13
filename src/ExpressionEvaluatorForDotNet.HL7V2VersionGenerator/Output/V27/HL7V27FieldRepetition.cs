using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27FieldRepetition
    {
        public HL7V2FieldRepetition fieldRepetition { get; init; }

        public IList<HL7V27Component> components { get; internal set; }

        public HL7V27FieldData fieldData { get; init; }

        public string Value { get { return fieldRepetition?.Value; } }
    }
}
