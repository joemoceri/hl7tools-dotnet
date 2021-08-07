using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventSRR_S07
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentERR err;


        public string Id { get { return @"SRR_S07"; } }
        public string MessageStructureId { get { return @"SRR_S07"; } }
        public string EventDescription { get { return @"Response addition of service/resource on appointment"; } }

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

        public HL7V23TriggerEventSRR_S07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);

        }
    }
}