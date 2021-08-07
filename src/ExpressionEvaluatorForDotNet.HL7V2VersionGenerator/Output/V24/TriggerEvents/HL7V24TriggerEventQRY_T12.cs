using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQRY_T12
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentQRD qrd;
public readonly HL7V24SegmentQRF qrf;


        public string Id { get { return @"QRY_T12"; } }
        public string MessageStructureId { get { return @"QRY_T12"; } }
        public string EventDescription { get { return @"Document query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
                    };
            }
        }

        public HL7V24TriggerEventQRY_T12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);

        }
    }
}
