namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2SubComponent : HL7V2FieldBase
    {
        public override int Id { get; set; }

        public override string Delimiter { get; set; }

        public override string Value { get; set; }

        public override void Rebuild()
        {

        }
    }
}