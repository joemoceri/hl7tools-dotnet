using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventQRY_PCE
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentQRD qrd{get; init;}
public HL7V23SegmentQRF qrf{get; init;}


        public string Id { get { return @"QRY_PCE"; } }
        public string MessageStructureId { get { return @"QRY_PCE"; } }
        public string EventDescription { get { return @"Pathway (problem-oriented) query"; } }

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

        public HL7V23TriggerEventQRY_PCE(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);

        }
    }
}
