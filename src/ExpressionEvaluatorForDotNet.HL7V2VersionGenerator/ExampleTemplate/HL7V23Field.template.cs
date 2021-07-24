namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator.ExampleTemplate
{
    public class HL7V23Field : HL7V2Field
    {
        public int Length { get; set; }

        public HL7V23DataType DataType { get; set; }

        public bool Optional { get; set; }

        public bool Repeatable { get; set; }

        public HL7V23Table Table { get; set; }
    }
}