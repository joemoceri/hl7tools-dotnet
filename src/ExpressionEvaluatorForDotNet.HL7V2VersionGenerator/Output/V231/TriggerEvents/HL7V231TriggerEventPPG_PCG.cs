using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventPPG_PCG
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentPID pid{get; init;}


        public string Id { get { return @"PPG_PCG"; } }
        public string MessageStructureId { get { return @"PPG_PCG"; } }
        public string EventDescription { get { return @"Pathway (goal-oriented) add"; } }

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

        public HL7V231TriggerEventPPG_PCG(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.pid = new HL7V231SegmentPID(this.message);

        }
    }
}
