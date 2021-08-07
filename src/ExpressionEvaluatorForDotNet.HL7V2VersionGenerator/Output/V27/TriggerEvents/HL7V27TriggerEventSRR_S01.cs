using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSRR_S01
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentMSA msa;
public readonly HL7V27SegmentERR err;


        public string Id { get { return @"SRR_S01"; } }
        public string MessageStructureId { get { return @"SRR_S01"; } }
        public string EventDescription { get { return @"Scheduled Request Response"; } }

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

        public HL7V27TriggerEventSRR_S01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);

        }
    }
}
