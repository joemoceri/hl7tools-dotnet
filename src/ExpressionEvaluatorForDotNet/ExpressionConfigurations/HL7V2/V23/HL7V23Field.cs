namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Field
    {
        public readonly HL7V2FieldBase field;
        public readonly HL7V23DataTypeField dataField;

        public HL7V23Field(HL7V2FieldBase field, HL7V23DataTypeField dataField)
        {
            this.field = field;
            this.dataField = dataField;
        }

        public string Value { get { return field.Value; } }
    }
}
