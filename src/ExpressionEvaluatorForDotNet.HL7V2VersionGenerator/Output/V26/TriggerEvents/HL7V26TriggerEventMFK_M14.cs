using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMFK_M14
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentMSA msa;
private readonly HL7V26SegmentERR err;
private readonly HL7V26SegmentMFI mfi;
private readonly HL7V26SegmentMFA mfa;


        public string Id { get { return @"MFK_M14"; } }
        public string MessageStructureId { get { return @"MFK_M14"; } }
        public string EventDescription { get { return @"Site Defined Master File Application Acknowledgment"; } }

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

        public HL7V26TriggerEventMFK_M14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.mfi = new HL7V26SegmentMFI(this.message);
this.mfa = new HL7V26SegmentMFA(this.message);

        }
    }
}
