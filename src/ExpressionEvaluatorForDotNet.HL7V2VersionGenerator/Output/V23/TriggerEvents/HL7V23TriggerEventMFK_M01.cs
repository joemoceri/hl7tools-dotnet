using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFK_M01
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentMSA msa;
private readonly HL7V23SegmentMFI mfi;
private readonly HL7V23SegmentERR err;
private readonly HL7V23SegmentMFA mfa;
private readonly HL7V23SegmentMFI mfi;


        public string Id { get { return @"MFK_M01"; } }
        public string MessageStructureId { get { return @"MFK_M01"; } }
        public string EventDescription { get { return @"Master file not otherwise specified acknowledgment"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V23TriggerEventMFK_M01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.mfa = new HL7V23SegmentMFA(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);

        }
    }
}
