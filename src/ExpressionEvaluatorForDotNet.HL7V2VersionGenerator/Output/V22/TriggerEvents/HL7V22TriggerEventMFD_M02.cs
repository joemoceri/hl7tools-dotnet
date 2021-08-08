using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventMFD_M02
    {
        private readonly HL7V2Message message;
        private readonly HL7V22SegmentMSH msh;
private readonly HL7V22SegmentMFI mfi;
private readonly HL7V22SegmentMFA mfa;


        public string Id { get { return @"MFD_M02"; } }
        public string MessageStructureId { get { return @"MFD_M02"; } }
        public string EventDescription { get { return @"Staff Practitioneer"; } }

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

        public HL7V22TriggerEventMFD_M02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.mfi = new HL7V22SegmentMFI(this.message);
this.mfa = new HL7V22SegmentMFA(this.message);

        }
    }
}
