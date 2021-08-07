using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventQRY_Q29
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentQRD qrd;
public readonly HL7V231SegmentQRF qrf;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"QRY_Q29"; } }
        public string MessageStructureId { get { return @"QRY_Q29"; } }
        public string EventDescription { get { return @"Pharmacy/treatment encoded order information query"; } }

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

        public HL7V231TriggerEventQRY_Q29(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
