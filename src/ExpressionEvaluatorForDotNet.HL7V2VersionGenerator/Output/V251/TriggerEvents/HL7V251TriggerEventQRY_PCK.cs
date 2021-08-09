using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQRY_PCK
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentQRD qrd{get; init;}
public HL7V251SegmentQRF qrf{get; init;}


        public string Id { get { return @"QRY_PCK"; } }
        public string MessageStructureId { get { return @"QRY_PCK"; } }
        public string EventDescription { get { return @"Patient pathway (goal-oriented) query"; } }

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

        public HL7V251TriggerEventQRY_PCK(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);

        }
    }
}
