namespace ExpressionEvaluatorForDotNet
{
    /// <summary>
    /// 
    /// </summary>
    public static class HL7V2MessageExtensions
    {
        // TODO: Add the rest of the versions
        public static HL7V23Message AsV23(this HL7V2Message message)
        {
            return new HL7V23Message(message);
        }
    }
}
