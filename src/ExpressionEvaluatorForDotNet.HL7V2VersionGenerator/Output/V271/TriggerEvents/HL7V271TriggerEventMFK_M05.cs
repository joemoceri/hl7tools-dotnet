using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventMFK_M05
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentMSA msa;
private readonly HL7V271SegmentERR err;
private readonly HL7V271SegmentMFI mfi;
private readonly HL7V271SegmentMFA mfa;


        public string Id { get { return @"MFK_M05"; } }
        public string MessageStructureId { get { return @"MFK_M05"; } }
        public string EventDescription { get { return @"Patient Location Master File Application Acknowledgment"; } }

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

        public HL7V271TriggerEventMFK_M05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.mfi = new HL7V271SegmentMFI(this.message);
this.mfa = new HL7V271SegmentMFA(this.message);

        }
    }
}
