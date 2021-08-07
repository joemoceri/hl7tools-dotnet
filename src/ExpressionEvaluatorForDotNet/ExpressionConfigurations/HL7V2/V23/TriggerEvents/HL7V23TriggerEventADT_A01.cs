using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventADT_A01
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMsh msh;

        public string Id { get { return "ADT_A01"; } }
        public string MessageStructureId { get { return "ADT_A01"; } }
        public string EventDescription { get { return "An A01 event is intended to be used for “Admitted” patients only.  \r\n\r\nAn A01 event is sent as a result of a patient undergoing the admission process which assigns the patient to a bed.  It signals the beginning of a patient’s stay in a healthcare facility.  Normally, this information is entered in the primary Patient Administration system and broadcast to the nursing units and ancillary systems.  It includes short stay and John Doe admissions."; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                {
                    "CH_03"
                };
            }
        }

        public HL7V23TriggerEventADT_A01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMsh(this.message);
        }
    }
}
