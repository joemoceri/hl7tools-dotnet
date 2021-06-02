namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V23Message
    {
        public readonly Msh msh;

        public HL7V23Message(HL7V2Message message)
        {
            msh = new Msh(message);
        }

        public class Msh
        {
            private HL7V2Message message;

            public Msh(HL7V2Message message)
            {
                this.message = message;
            }

            public HL7V2FieldBase FieldSeparator { get { return message.Get("MSH.1"); } }
            public HL7V2FieldBase EncodingCharacters { get { return message.Get("MSH.2"); } }
            public HL7V2FieldBase SendingApplication { get { return message.Get("MSH.3"); } }
            public HL7V2FieldBase SendingFacility { get { return message.Get("MSH.4"); } }
            public HL7V2FieldBase ReceivingApplication { get { return message.Get("MSH.5"); } }
            public HL7V2FieldBase ReceivingFacility { get { return message.Get("MSH.6"); } }
            public HL7V2FieldBase DateTimeOfMessage { get { return message.Get("MSH.7"); } }
            public HL7V2FieldBase Security { get { return message.Get("MSH.8"); } }
            public HL7V2FieldBase MessageType { get { return message.Get("MSH.9"); } }
            public HL7V2FieldBase MessageControlId { get { return message.Get("MSH.10"); } }
            public HL7V2FieldBase ProcessingId { get { return message.Get("MSH.11"); } }
            public HL7V2FieldBase VersionId { get { return message.Get("MSH.12"); } }
            public HL7V2FieldBase SequenceNumber { get { return message.Get("MSH.13"); } }
            public HL7V2FieldBase ContinuationPointer { get { return message.Get("MSH.14"); } }
            public HL7V2FieldBase AcceptAcknowledgementType { get { return message.Get("MSH.15"); } }
            public HL7V2FieldBase ApplicationAcknowledgementType { get { return message.Get("MSH.16"); } }
            public HL7V2FieldBase CountryCode { get { return message.Get("MSH.17"); } }
            public HL7V2FieldBase CharacterSet { get { return message.Get("MSH.18"); } }
            public HL7V2FieldBase PrincipleLanguageOfMessage { get { return message.Get("MSH.19"); } }
        }
    }
}
