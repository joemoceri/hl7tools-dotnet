using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRQQ_Q09
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentERQ erq;
public readonly HL7V26SegmentDSC dsc;


        public string Id { get { return @"RQQ_Q09"; } }
        public string MessageStructureId { get { return @"RQQ_Q09"; } }
        public string EventDescription { get { return @"Event Replay Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V26TriggerEventRQQ_Q09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.erq = new HL7V26SegmentERQ(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
