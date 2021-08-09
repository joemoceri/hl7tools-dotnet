using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFD_MFA
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMFI mfi{ get; init; }
public HL7V231SegmentMFA mfa{ get; init; }


        public string Id { get { return @"MFD_MFA"; } }
        public string MessageStructureId { get { return @"MFD_MFA"; } }
        public string EventDescription { get { return @"Master file delayed application acknowledgment"; } }

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

        public HL7V231TriggerEventMFD_MFA(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.mfi = new HL7V231SegmentMFI(this.message);
this.mfa = new HL7V231SegmentMFA(this.message);

        }
    }
}
