using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventQRY_Q01
    {
        public HL7V2Message message { get; init; }
        public HL7V21SegmentMSH msh{ get; init; }
public HL7V21SegmentQRD qrd{ get; init; }
public HL7V21SegmentQRF qrf{ get; init; }
public HL7V21SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QRY_Q01"; } }
        public string MessageStructureId { get { return @"QRY_Q01"; } }
        public string EventDescription { get { return @"A Query is Made for Immediate Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventQRY_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.qrd = new HL7V21SegmentQRD(this.message);
this.qrf = new HL7V21SegmentQRF(this.message);
this.dsc = new HL7V21SegmentDSC(this.message);

        }
    }
}
