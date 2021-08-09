using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventPPP_PCD
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentPID pid{ get; init; }


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

        public HL7V25TriggerEventPPP_PCD(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.pid = new HL7V25SegmentPID(this.message);

        }
    }
}
