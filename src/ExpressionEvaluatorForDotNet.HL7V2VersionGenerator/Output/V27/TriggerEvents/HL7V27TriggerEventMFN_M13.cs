using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventMFN_M13
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentMFI mfi{ get; init; }
public HL7V27SegmentMFE mfe{ get; init; }


        public string Id { get { return @"MFN_M13"; } }
        public string MessageStructureId { get { return @"MFN_M13"; } }
        public string EventDescription { get { return @"Master file notification - general"; } }

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

        public HL7V27TriggerEventMFN_M13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.mfi = new HL7V27SegmentMFI(this.message);
this.mfe = new HL7V27SegmentMFE(this.message);

        }
    }
}
