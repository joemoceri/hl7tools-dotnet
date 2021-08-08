using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventQRY_Q29
    {
        private readonly HL7V2Message message;
        private readonly HL7V22SegmentMSH msh;
private readonly HL7V22SegmentQRD qrd;
private readonly HL7V22SegmentQRF qrf;
private readonly HL7V22SegmentDSC dsc;


        public string Id { get { return @"QRY_Q29"; } }
        public string MessageStructureId { get { return @"QRY_Q29"; } }
        public string EventDescription { get { return @"Pharmacy Encoded Order Information Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
"CH_04",

                    };
            }
        }

        public HL7V22TriggerEventQRY_Q29(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);
this.qrf = new HL7V22SegmentQRF(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
