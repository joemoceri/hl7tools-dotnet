using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRQQ_Q09
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentERQ erq;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"RQQ_Q09"; } }
        public string MessageStructureId { get { return @"RQQ_Q09"; } }
        public string EventDescription { get { return @"Event replay query"; } }

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

        public HL7V25TriggerEventRQQ_Q09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.erq = new HL7V25SegmentERQ(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
