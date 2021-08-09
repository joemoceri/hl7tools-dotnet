using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQRY_R02
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentQRD qrd{get; init;}
public HL7V251SegmentQRF qrf{get; init;}


        public string Id { get { return @"QRY_R02"; } }
        public string MessageStructureId { get { return @"QRY_R02"; } }
        public string EventDescription { get { return @"Query for results of observation"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V251TriggerEventQRY_R02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);

        }
    }
}
