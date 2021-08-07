using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFK_M01
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentMSA msa;
public readonly HL7V24SegmentMFI mfi;
public readonly HL7V24SegmentMFA mfa;


        public string Id { get { return @"MFK_M01"; } }
        public string MessageStructureId { get { return @"MFK_M01"; } }
        public string EventDescription { get { return @"Master file application acknowledgment"; } }

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

        public HL7V24TriggerEventMFK_M01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);
this.mfa = new HL7V24SegmentMFA(this.message);

        }
    }
}
