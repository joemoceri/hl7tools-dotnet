using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventQRY_PC9
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentQRD qrd;
public readonly HL7V27SegmentQRF qrf;


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

        public HL7V27TriggerEventQRY_PC9(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.qrd = new HL7V27SegmentQRD(this.message);
this.qrf = new HL7V27SegmentQRF(this.message);

        }
    }
}
