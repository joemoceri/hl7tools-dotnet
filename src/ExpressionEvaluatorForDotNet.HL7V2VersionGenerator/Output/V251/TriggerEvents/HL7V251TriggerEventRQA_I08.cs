using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRQA_I08
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentRF1 rf1{get; init;}
public HL7V251SegmentPID pid{get; init;}
public HL7V251SegmentNK1 nk1{get; init;}
public HL7V251SegmentACC acc{get; init;}
public HL7V251SegmentDG1 dg1{get; init;}
public HL7V251SegmentDRG drg{get; init;}
public HL7V251SegmentAL1 al1{get; init;}
public HL7V251SegmentNTE nte{get; init;}


        public string Id { get { return @"RQA_I08"; } }
        public string MessageStructureId { get { return @"RQA_I08"; } }
        public string EventDescription { get { return @"Request for treatment authorization information"; } }

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

        public HL7V251TriggerEventRQA_I08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.rf1 = new HL7V251SegmentRF1(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.nk1 = new HL7V251SegmentNK1(this.message);
this.acc = new HL7V251SegmentACC(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.al1 = new HL7V251SegmentAL1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
