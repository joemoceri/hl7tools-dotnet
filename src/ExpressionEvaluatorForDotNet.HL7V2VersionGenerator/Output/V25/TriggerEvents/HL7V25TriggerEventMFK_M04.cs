using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFK_M04
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;
public readonly HL7V25SegmentMFI mfi;
public readonly HL7V25SegmentMFA mfa;


        public string Id { get { return @"MFK_M04"; } }
        public string MessageStructureId { get { return @"MFK_M04"; } }
        public string EventDescription { get { return @"Master file acknowledgment - Charge description master file"; } }

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

        public HL7V25TriggerEventMFK_M04(HL7V2Message message)
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