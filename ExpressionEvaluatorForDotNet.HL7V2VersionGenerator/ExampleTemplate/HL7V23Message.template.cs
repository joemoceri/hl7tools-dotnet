using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator.ExampleTemplate
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

            public HL7V23Field FieldSeparator { get { return (HL7V23Field)message.Get("MSH.1"); } }
            public HL7V23Field EncodingCharacters { get { return (HL7V23Field)message.Get("MSH.2"); } }
            public HL7V23Field SendingApplication { get { return (HL7V23Field)message.Get("MSH.3"); } }
            public HL7V23Field SendingFacility { get { return (HL7V23Field)message.Get("MSH.4"); } }
            public HL7V23Field ReceivingApplication { get { return (HL7V23Field)message.Get("MSH.5"); } }
            public HL7V23Field ReceivingFacility { get { return (HL7V23Field)message.Get("MSH.6"); } }
            public HL7V23Field DateTimeOfMessage { get { return (HL7V23Field)message.Get("MSH.7"); } }
            public HL7V23Field Security { get { return (HL7V23Field)message.Get("MSH.8"); } }
            public HL7V23Field MessageType { get { return (HL7V23Field)message.Get("MSH.9"); } }
            public HL7V23Field MessageControlId { get { return (HL7V23Field)message.Get("MSH.10"); } }
            public HL7V23Field ProcessingId { get { return (HL7V23Field)message.Get("MSH.11"); } }
            public HL7V23Field VersionId { get { return (HL7V23Field)message.Get("MSH.12"); } }
            public HL7V23Field SequenceNumber { get { return (HL7V23Field)message.Get("MSH.13"); } }
            public HL7V23Field ContinuationPointer { get { return (HL7V23Field)message.Get("MSH.14"); } }
            public HL7V23Field AcceptAcknowledgementType { get { return (HL7V23Field)message.Get("MSH.15"); } }
            public HL7V23Field ApplicationAcknowledgementType { get { return (HL7V23Field)message.Get("MSH.16"); } }
            public HL7V23Field CountryCode { get { return (HL7V23Field)message.Get("MSH.17"); } }
            public HL7V23Field CharacterSet { get { return (HL7V23Field)message.Get("MSH.18"); } }
            public HL7V23Field PrincipleLanguageOfMessage { get { return (HL7V23Field)message.Get("MSH.19"); } }
        }
    }
}
