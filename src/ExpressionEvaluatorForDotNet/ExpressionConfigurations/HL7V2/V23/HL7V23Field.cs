using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Field
    {
        public readonly HL7V2Field field;
        public readonly IList<HL7V2FieldRepetition> fieldRepetitions;
        public readonly HL7V2FieldData fieldData;

        public HL7V23Field(HL7V2Field field, HL7V2FieldData fieldData, IList<HL7V2FieldRepetition> fieldRepetitions = null)
        {
            this.field = field;
            this.fieldData = fieldData;
            this.fieldRepetitions = fieldRepetitions;
        }

        public string Value { get { return field.Value; } }
    }
}
