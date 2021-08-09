using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventCCR_I17
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentRF1 rf1{get; init;}
public HL7V271SegmentNK1 nk1{get; init;}
public HL7V271SegmentREL rel{get; init;}


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

        public HL7V271TriggerEventCCR_I17(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.rf1 = new HL7V271SegmentRF1(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.rel = new HL7V271SegmentREL(this.message);

        }
    }
}
