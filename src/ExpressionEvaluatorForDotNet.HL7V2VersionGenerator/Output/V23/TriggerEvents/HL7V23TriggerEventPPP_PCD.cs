using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventPPP_PCD
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentPID pid{get; init;}


        public string Id { get { return @"PPP_PCD"; } }
        public string MessageStructureId { get { return @"PPP_PCD"; } }
        public string EventDescription { get { return @"Pathway (problem-oriented) delete"; } }

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

        public HL7V23TriggerEventPPP_PCD(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.pid = new HL7V23SegmentPID(this.message);

        }
    }
}
