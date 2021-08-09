using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFN_M02
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMFI mfi{get; init;}


        public string Id { get { return @"MFN_M02"; } }
        public string MessageStructureId { get { return @"MFN_M02"; } }
        public string EventDescription { get { return @"Master files notification - Staff/practitioner master file"; } }

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

        public HL7V24TriggerEventMFN_M02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);

        }
    }
}
