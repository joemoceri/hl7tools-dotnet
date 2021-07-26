namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeField
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string Position { get; set; }

        public string Name { get; set; }

        public int Length { get; set; }

        public string Usage { get; set; }

        public string Rpt { get; set; }

        public string DataType { get; set; }

        public string DataTypeName { get; set; }

        public string TableId { get; set; }

        public string TableName { get; set; }

        public string Description { get; set; }

        public string Sample { get; set; }

        public HL7V23DataTypeField[] Fields { get; set; }
    }
}
