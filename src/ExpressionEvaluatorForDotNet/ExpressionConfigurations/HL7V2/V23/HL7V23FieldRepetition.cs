using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23FieldRepetition
    {
        public readonly HL7V2FieldRepetition fieldRepetition;
        public readonly IList<HL7V23Component> components;
        public readonly HL7V2FieldData fieldData;

        public HL7V23FieldRepetition(HL7V2FieldRepetition fieldRepetition, HL7V2FieldData fieldData, IList<HL7V23Component> components)
        {
            this.fieldRepetition = fieldRepetition;
            this.fieldData = fieldData;
            this.components = components;
        }

        public string Value { get { return fieldRepetition.Value; } }
    }
}
