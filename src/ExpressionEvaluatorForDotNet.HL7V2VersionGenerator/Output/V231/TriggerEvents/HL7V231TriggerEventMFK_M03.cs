using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFK_M03
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentMSA msa;
public readonly HL7V231SegmentERR err;
public readonly HL7V231SegmentMFI mfi;
public readonly HL7V231SegmentMFA mfa;


        public string Id { get { return @"MFK_M03"; } }
        public string MessageStructureId { get { return @"MFK_M03"; } }
        public string EventDescription { get { return @"Master file - Test/Observation acknowledgment"; } }

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

        public HL7V231TriggerEventMFK_M03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.mfi = new HL7V231SegmentMFI(this.message);
this.mfa = new HL7V231SegmentMFA(this.message);

        }
    }
}
