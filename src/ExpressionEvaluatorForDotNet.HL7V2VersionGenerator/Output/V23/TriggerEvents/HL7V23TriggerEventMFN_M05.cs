using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFN_M05
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentMFI mfi{get; init;}


        public string Id { get { return @"MFN_M05"; } }
        public string MessageStructureId { get { return @"MFN_M05"; } }
        public string EventDescription { get { return @"Patient location master file"; } }

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

        public HL7V23TriggerEventMFN_M05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);

        }
    }
}
