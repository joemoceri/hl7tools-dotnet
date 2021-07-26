namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23MshSegment
    {
        public readonly HL7V2Message message;

        public HL7V23MshSegment(HL7V2Message message)
        {
            this.message = message;
        }

        public HL7V23Field FieldSeparator { get { return new HL7V23Field(message.Get("MSH.1")); } }
        public HL7V23Field EncodingCharacters { get { return new HL7V23Field(message.Get("MSH.2")); } }
        public HL7V23Field SendingApplication { get { return new HL7V23Field(message.Get("MSH.3")); } }
        public HL7V23Field SendingFacility { get { return new HL7V23Field(message.Get("MSH.4")); } }
        public HL7V23Field ReceivingApplication { get { return new HL7V23Field(message.Get("MSH.5")); } }
        public HL7V23Field ReceivingFacility { get { return new HL7V23Field(message.Get("MSH.6")); } }
        public HL7V23Field DateTimeOfMessage { get { return new HL7V23Field(message.Get("MSH.7")); } }
        public HL7V23Field Security { get { return new HL7V23Field(message.Get("MSH.8")); } }
        public HL7V23Field MessageType { get { return new HL7V23Field(message.Get("MSH.9")); } }
        public HL7V23Field MessageControlId { get { return new HL7V23Field(message.Get("MSH.10")); } }
        public HL7V23Field ProcessingId { get { return new HL7V23Field(message.Get("MSH.11")); } }
        public HL7V23Field VersionId { get { return new HL7V23Field(message.Get("MSH.12")); } }
        public HL7V23Field SequenceNumber { get { return new HL7V23Field(message.Get("MSH.13")); } }
        public HL7V23Field ContinuationPointer { get { return new HL7V23Field(message.Get("MSH.14")); } }
        public HL7V23Field AcceptAcknowledgementType { get { return new HL7V23Field(message.Get("MSH.15")); } }
        public HL7V23Field ApplicationAcknowledgementType { get { return new HL7V23Field(message.Get("MSH.16")); } }
        public HL7V23Field CountryCode { get { return new HL7V23Field(message.Get("MSH.17")); } }
        public HL7V23Field CharacterSet { get { return new HL7V23Field(message.Get("MSH.18")); } }
        public HL7V23Field PrincipleLanguageOfMessage { get { return new HL7V23Field(message.Get("MSH.19")); } }
    }
}
