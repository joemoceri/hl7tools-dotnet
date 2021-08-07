using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventCCR_I17
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentRF1 rf1;
public readonly HL7V27SegmentNK1 nk1;
public readonly HL7V27SegmentREL rel;


        public string Id { get { return @"CCR_I17"; } }
        public string MessageStructureId { get { return @"CCR_I17"; } }
        public string EventDescription { get { return @"Modify Collaborative Care Referral"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
                    };
            }
        }

        public HL7V27TriggerEventCCR_I17(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.rf1 = new HL7V27SegmentRF1(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.rel = new HL7V27SegmentREL(this.message);

        }
    }
}
