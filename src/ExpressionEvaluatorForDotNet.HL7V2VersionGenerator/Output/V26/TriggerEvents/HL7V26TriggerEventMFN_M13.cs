using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMFN_M13
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMFI mfi;
public readonly HL7V26SegmentMFE mfe;


        public string Id { get { return @"MFN_M13"; } }
        public string MessageStructureId { get { return @"MFN_M13"; } }
        public string EventDescription { get { return @"General Master File Notification"; } }

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

        public HL7V26TriggerEventMFN_M13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.mfi = new HL7V26SegmentMFI(this.message);
this.mfe = new HL7V26SegmentMFE(this.message);

        }
    }
}
