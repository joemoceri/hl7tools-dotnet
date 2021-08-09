using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventQRY_P04
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentQRD qrd{ get; init; }
public HL7V23SegmentQRF qrf{ get; init; }
public HL7V23SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QRY_P04"; } }
        public string MessageStructureId { get { return @"QRY_P04"; } }
        public string EventDescription { get { return @"Generate bills and accounts receivable statements"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V23TriggerEventQRY_P04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
