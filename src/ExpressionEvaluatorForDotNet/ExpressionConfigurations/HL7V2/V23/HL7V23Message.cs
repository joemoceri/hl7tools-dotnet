namespace ExpressionEvaluatorForDotNet 
{
    public class HL7V23Message
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMsh msh;

        public HL7V23Message(HL7V2Message message)
        {
            this.message = message;
            msh = new HL7V23SegmentMsh(message);
        }

        public HL7V23TriggerEventADT_A01 GetADT_A01()
        {
            // TODO: Fill this out, validate
            return new HL7V23TriggerEventADT_A01(this);
        }
    }
}
