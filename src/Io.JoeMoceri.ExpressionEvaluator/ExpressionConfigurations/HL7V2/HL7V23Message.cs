namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V23Message
    {
        public readonly HL7V2Message message;
        public readonly Msh msh;

        public HL7V23Message(HL7V2Message message)
        {
            this.message = message;
            msh = new Msh(message);
        }

        public class Msh
        {
            public readonly HL7V2Message message;

            public Msh(HL7V2Message message)
            {
                this.message = message;
            }

            public HL7V2Field FieldSeparator { get { return (HL7V2Field)message.Get("MSH.1"); } }
            public HL7V2Field EncodingCharacters { get { return (HL7V2Field)message.Get("MSH.2"); } }
            public HL7V2Field SendingApplication { get { return (HL7V2Field)message.Get("MSH.3"); } }
            public HL7V2Field SendingFacility { get { return (HL7V2Field)message.Get("MSH.4"); } }
            public HL7V2Field ReceivingApplication { get { return (HL7V2Field)message.Get("MSH.5"); } }
            public HL7V2Field ReceivingFacility { get { return (HL7V2Field)message.Get("MSH.6"); } }
            public HL7V2Field DateTimeOfMessage { get { return (HL7V2Field)message.Get("MSH.7"); } }
            public HL7V2Field Security { get { return (HL7V2Field)message.Get("MSH.8"); } }
            public HL7V2Field MessageType { get { return (HL7V2Field)message.Get("MSH.9"); } }
            public HL7V2Field MessageControlId { get { return (HL7V2Field)message.Get("MSH.10"); } }
            public HL7V2Field ProcessingId { get { return (HL7V2Field)message.Get("MSH.11"); } }
            public HL7V2Field VersionId { get { return (HL7V2Field)message.Get("MSH.12"); } }
            public HL7V2Field SequenceNumber { get { return (HL7V2Field)message.Get("MSH.13"); } }
            public HL7V2Field ContinuationPointer { get { return (HL7V2Field)message.Get("MSH.14"); } }
            public HL7V2Field AcceptAcknowledgementType { get { return (HL7V2Field)message.Get("MSH.15"); } }
            public HL7V2Field ApplicationAcknowledgementType { get { return (HL7V2Field)message.Get("MSH.16"); } }
            public HL7V2Field CountryCode { get { return (HL7V2Field)message.Get("MSH.17"); } }
            public HL7V2Field CharacterSet { get { return (HL7V2Field)message.Get("MSH.18"); } }
            public HL7V2Field PrincipleLanguageOfMessage { get { return (HL7V2Field)message.Get("MSH.19"); } }
        }
    }
}
