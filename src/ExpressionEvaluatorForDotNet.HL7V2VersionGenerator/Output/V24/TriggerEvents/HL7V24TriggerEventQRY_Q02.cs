using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQRY_Q02
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentQRD qrd{ get; init; }
public HL7V24SegmentQRF qrf{ get; init; }
public HL7V24SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QRY_Q02"; } }
        public string MessageStructureId { get { return @"QRY_Q02"; } }
        public string EventDescription { get { return @"Query sent for deferred response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V24TriggerEventQRY_Q02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
