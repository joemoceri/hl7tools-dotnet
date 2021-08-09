using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMFN_M01
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentMFI mfi{get; init;}


        public string Id { get { return @"MFN_M01"; } }
        public string MessageStructureId { get { return @"MFN_M01"; } }
        public string EventDescription { get { return @"Master File Notification"; } }

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

        public HL7V26TriggerEventMFN_M01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.mfi = new HL7V26SegmentMFI(this.message);

        }
    }
}
