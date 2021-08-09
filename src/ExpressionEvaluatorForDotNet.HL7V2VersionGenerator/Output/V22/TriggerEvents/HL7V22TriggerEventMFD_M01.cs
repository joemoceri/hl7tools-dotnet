using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventMFD_M01
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentMFI mfi{get; init;}
public HL7V22SegmentMFA mfa{get; init;}


        public string Id { get { return @"MFD_M01"; } }
        public string MessageStructureId { get { return @"MFD_M01"; } }
        public string EventDescription { get { return @"Master files change not otherwise specified (for backwards comp.)"; } }

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

        public HL7V22TriggerEventMFD_M01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.mfi = new HL7V22SegmentMFI(this.message);
this.mfa = new HL7V22SegmentMFA(this.message);

        }
    }
}
