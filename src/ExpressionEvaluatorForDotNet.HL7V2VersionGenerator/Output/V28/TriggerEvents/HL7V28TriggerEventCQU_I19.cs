using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventCQU_I19
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentMSA msa;
private readonly HL7V28SegmentERR err;
private readonly HL7V28SegmentRF1 rf1;
private readonly HL7V28SegmentNK1 nk1;
private readonly HL7V28SegmentREL rel;


        public string Id { get { return @"CQU_I19"; } }
        public string MessageStructureId { get { return @"CQU_I19"; } }
        public string EventDescription { get { return @"Collaborative Care Referral"; } }

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

        public HL7V28TriggerEventCQU_I19(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.rf1 = new HL7V28SegmentRF1(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.rel = new HL7V28SegmentREL(this.message);

        }
    }
}
