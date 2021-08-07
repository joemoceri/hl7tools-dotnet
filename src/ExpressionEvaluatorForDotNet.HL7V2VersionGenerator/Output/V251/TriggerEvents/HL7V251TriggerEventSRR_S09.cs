using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventSRR_S09
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentMSA msa;
public readonly HL7V251SegmentERR err;


        public string Id { get { return @"SRR_S09"; } }
        public string MessageStructureId { get { return @"SRR_S09"; } }
        public string EventDescription { get { return @"Scheduled request response - Cancellation of service/resource on appointment"; } }

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

        public HL7V251TriggerEventSRR_S09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);

        }
    }
}
