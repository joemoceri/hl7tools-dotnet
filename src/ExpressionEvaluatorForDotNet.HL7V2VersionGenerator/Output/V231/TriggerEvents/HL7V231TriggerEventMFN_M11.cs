using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFN_M11
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMFI mfi{ get; init; }


        public string Id { get { return @"MFN_M11"; } }
        public string MessageStructureId { get { return @"MFN_M11"; } }
        public string EventDescription { get { return @"Test/calculated observations master file"; } }

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

        public HL7V231TriggerEventMFN_M11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.mfi = new HL7V231SegmentMFI(this.message);

        }
    }
}
