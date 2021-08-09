using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventPPR_PC3
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentPID pid{get; init;}


        public string Id { get { return @"PPR_PC3"; } }
        public string MessageStructureId { get { return @"PPR_PC3"; } }
        public string EventDescription { get { return @"Problem delete"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V251TriggerEventPPR_PC3(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.pid = new HL7V251SegmentPID(this.message);

        }
    }
}
