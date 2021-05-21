namespace Io.JoeMoceri.ExpressionEvaluator
{
    public interface IHL7V2Field
    {
        int Id { get; set; }

        string Delimiter { get; set; }

        string Value { get; set; }
    }
}