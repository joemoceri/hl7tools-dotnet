using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMFK_M09
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentMSA msa{ get; init; }
public HL7V26SegmentERR err{ get; init; }
public HL7V26SegmentMFI mfi{ get; init; }
public HL7V26SegmentMFA mfa{ get; init; }


        public string Id { get { return @"MFK_M09"; } }
        public string MessageStructureId { get { return @"MFK_M09"; } }
        public string EventDescription { get { return @"Test/Observation (Categorical) Master File Application Acknowledgment"; } }

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

        public HL7V26TriggerEventMFK_M09(HL7V2Message message)
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
