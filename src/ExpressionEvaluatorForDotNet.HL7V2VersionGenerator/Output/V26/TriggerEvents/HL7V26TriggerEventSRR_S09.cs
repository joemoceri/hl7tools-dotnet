using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSRR_S09
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentERR err;


        public string Id { get { return @"SRR_S09"; } }
        public string MessageStructureId { get { return @"SRR_S09"; } }
        public string EventDescription { get { return @"Scheduled Request Response - Request Cancellation of Service/Resource on Appointment "; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
                    };
            }
        }

        public HL7V26TriggerEventSRR_S09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);

        }
    }
}
