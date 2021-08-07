using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventQRY_P04
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentQRD qrd;
public readonly HL7V22SegmentQRF qrf;
public readonly HL7V22SegmentDSC dsc;


        public string Id { get { return @"QRY_P04"; } }
        public string MessageStructureId { get { return @"QRY_P04"; } }
        public string EventDescription { get { return @"Generate bills and A/R statements"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            }
        }

        public HL7V22TriggerEventQRY_P04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);
this.qrf = new HL7V22SegmentQRF(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
