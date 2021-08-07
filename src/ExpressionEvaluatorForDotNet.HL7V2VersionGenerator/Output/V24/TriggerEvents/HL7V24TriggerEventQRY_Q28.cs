using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQRY_Q28
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentQRD qrd;
public readonly HL7V24SegmentQRF qrf;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"QRY_Q28"; } }
        public string MessageStructureId { get { return @"QRY_Q28"; } }
        public string EventDescription { get { return @"Pharmacy/treatment dispense information query"; } }

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

        public HL7V24TriggerEventQRY_Q28(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
