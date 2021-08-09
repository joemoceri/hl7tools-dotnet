using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventQRY_PC9
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentQRD qrd{ get; init; }
public HL7V271SegmentQRF qrf{ get; init; }


        public string Id { get { return @"QRY_PC9"; } }
        public string MessageStructureId { get { return @"QRY_PC9"; } }
        public string EventDescription { get { return @"PC/ goal query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V271TriggerEventQRY_PC9(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.qrd = new HL7V271SegmentQRD(this.message);
this.qrf = new HL7V271SegmentQRF(this.message);

        }
    }
}
