using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFK_M09
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentMSA msa{ get; init; }
public HL7V23SegmentMFI mfi{ get; init; }
public HL7V23SegmentMFA mfa{ get; init; }


        public string Id { get { return @"MFK_M09"; } }
        public string MessageStructureId { get { return @"MFK_M09"; } }
        public string EventDescription { get { return @"Test/observation (categorical) master file acknowledgment"; } }

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

        public HL7V23TriggerEventMFK_M09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);
this.mfa = new HL7V23SegmentMFA(this.message);

        }
    }
}
