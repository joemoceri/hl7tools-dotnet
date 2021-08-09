using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventEAR_U08
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentEQU equ{ get; init; }
public HL7V26SegmentROL rol{ get; init; }


        public string Id { get { return @"EAR_U08"; } }
        public string MessageStructureId { get { return @"EAR_U08"; } }
        public string EventDescription { get { return @"Automated Equipment Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V26TriggerEventEAR_U08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.equ = new HL7V26SegmentEQU(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}
