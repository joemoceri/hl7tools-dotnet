using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventQRY_Q26
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentQRD qrd;
public readonly HL7V23SegmentQRF qrf;
public readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"QRY_Q26"; } }
        public string MessageStructureId { get { return @"QRY_Q26"; } }
        public string EventDescription { get { return @"Pharmacy/treatment order query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            }
        }

        public HL7V23TriggerEventQRY_Q26(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
