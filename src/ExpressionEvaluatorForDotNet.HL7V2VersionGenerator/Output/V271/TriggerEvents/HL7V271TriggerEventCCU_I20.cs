using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventCCU_I20
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentRF1 rf1{get; init;}
public HL7V271SegmentNK1 nk1{get; init;}
public HL7V271SegmentREL rel{get; init;}


        public string Id { get { return @"CCU_I20"; } }
        public string MessageStructureId { get { return @"CCU_I20"; } }
        public string EventDescription { get { return @"Asynchronous Collaborative Care Update"; } }

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

        public HL7V271TriggerEventCCU_I20(HL7V2Message message)
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
