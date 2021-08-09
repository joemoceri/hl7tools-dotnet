using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMFN_M13
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentMFI mfi{ get; init; }
public HL7V251SegmentMFE mfe{ get; init; }


        public string Id { get { return @"MFN_M13"; } }
        public string MessageStructureId { get { return @"MFN_M13"; } }
        public string EventDescription { get { return @"Master File Notification - General"; } }

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

        public HL7V251TriggerEventMFN_M13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.mfi = new HL7V251SegmentMFI(this.message);
this.mfe = new HL7V251SegmentMFE(this.message);

        }
    }
}
