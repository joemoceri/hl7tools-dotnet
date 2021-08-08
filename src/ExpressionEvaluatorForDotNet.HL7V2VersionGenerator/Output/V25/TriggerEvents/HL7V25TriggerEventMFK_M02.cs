using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFK_M02
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentMSA msa;
private readonly HL7V25SegmentERR err;
private readonly HL7V25SegmentMFI mfi;
private readonly HL7V25SegmentMFA mfa;


        public string Id { get { return @"MFK_M02"; } }
        public string MessageStructureId { get { return @"MFK_M02"; } }
        public string EventDescription { get { return @"Master file acknowledgment - Staff/practitioner master file"; } }

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

        public HL7V25TriggerEventMFK_M02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.mfi = new HL7V25SegmentMFI(this.message);
this.mfa = new HL7V25SegmentMFA(this.message);

        }
    }
}
