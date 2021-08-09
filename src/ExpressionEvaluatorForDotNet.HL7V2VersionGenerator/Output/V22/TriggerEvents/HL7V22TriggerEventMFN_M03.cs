using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventMFN_M03
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentMFI mfi{ get; init; }


        public string Id { get { return @"MFN_M03"; } }
        public string MessageStructureId { get { return @"MFN_M03"; } }
        public string EventDescription { get { return @"Test/Observation"; } }

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

        public HL7V22TriggerEventMFN_M03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.mfi = new HL7V22SegmentMFI(this.message);

        }
    }
}
