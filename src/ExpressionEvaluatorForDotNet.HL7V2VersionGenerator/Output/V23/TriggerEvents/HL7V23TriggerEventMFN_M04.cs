using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFN_M04
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentMFI mfi{get; init;}


        public string Id { get { return @"MFN_M04"; } }
        public string MessageStructureId { get { return @"MFN_M04"; } }
        public string EventDescription { get { return @"Master files charge description"; } }

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

        public HL7V23TriggerEventMFN_M04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);

        }
    }
}
