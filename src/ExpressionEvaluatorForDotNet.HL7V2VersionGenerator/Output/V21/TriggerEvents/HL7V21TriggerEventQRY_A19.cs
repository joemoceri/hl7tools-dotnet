using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventQRY_A19
    {
        public readonly HL7V2Message message;
        public readonly HL7V21SegmentMSH msh;
public readonly HL7V21SegmentQRD qrd;


        public string Id { get { return @"QRY_A19"; } }
        public string MessageStructureId { get { return @"QRY_A19"; } }
        public string EventDescription { get { return @"Patient Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventQRY_A19(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.qrd = new HL7V21SegmentQRD(this.message);

        }
    }
}