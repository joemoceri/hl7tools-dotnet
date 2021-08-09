using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventPPP_PCB
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentPID pid{get; init;}


        public string Id { get { return @"PPP_PCB"; } }
        public string MessageStructureId { get { return @"PPP_PCB"; } }
        public string EventDescription { get { return @"Pathway (problem-oriented) add"; } }

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

        public HL7V231TriggerEventPPP_PCB(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.pid = new HL7V231SegmentPID(this.message);

        }
    }
}
