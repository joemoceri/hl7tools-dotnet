using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventQRY_PCK
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentQRD qrd;
public readonly HL7V231SegmentQRF qrf;


        public string Id { get { return @"QRY_PCK"; } }
        public string MessageStructureId { get { return @"QRY_PCK"; } }
        public string EventDescription { get { return @"Pathway (goal-oriented) query"; } }

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

        public HL7V231TriggerEventQRY_PCK(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);

        }
    }
}
