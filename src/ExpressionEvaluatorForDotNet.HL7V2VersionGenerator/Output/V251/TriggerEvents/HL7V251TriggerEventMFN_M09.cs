using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMFN_M09
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentMFI mfi{get; init;}


        public string Id { get { return @"MFN_M09"; } }
        public string MessageStructureId { get { return @"MFN_M09"; } }
        public string EventDescription { get { return @"Master File Notification - Test/Observation (Categorical)"; } }

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

        public HL7V251TriggerEventMFN_M09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.mfi = new HL7V251SegmentMFI(this.message);

        }
    }
}
