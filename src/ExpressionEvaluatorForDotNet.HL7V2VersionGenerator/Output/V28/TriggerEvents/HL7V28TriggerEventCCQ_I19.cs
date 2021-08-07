using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventCCQ_I19
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentRF1 rf1;
public readonly HL7V28SegmentREL rel;


        public string Id { get { return @"CCQ_I19"; } }
        public string MessageStructureId { get { return @"CCQ_I19"; } }
        public string EventDescription { get { return @"Collaborative Care Query/Collaborative Care Query Update"; } }

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

        public HL7V28TriggerEventCCQ_I19(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.rf1 = new HL7V28SegmentRF1(this.message);
this.rel = new HL7V28SegmentREL(this.message);

        }
    }
}
