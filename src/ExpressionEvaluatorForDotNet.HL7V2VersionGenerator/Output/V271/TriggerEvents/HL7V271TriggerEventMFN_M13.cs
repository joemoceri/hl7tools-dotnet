using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventMFN_M13
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentMFI mfi;
public readonly HL7V271SegmentMFE mfe;


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

        public HL7V271TriggerEventMFN_M13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.mfi = new HL7V271SegmentMFI(this.message);
this.mfe = new HL7V271SegmentMFE(this.message);

        }
    }
}