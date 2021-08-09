using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventQRY_PC4
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentQRD qrd{get; init;}
public HL7V25SegmentQRF qrf{get; init;}


        public string Id { get { return @"QRY_PC4"; } }
        public string MessageStructureId { get { return @"QRY_PC4"; } }
        public string EventDescription { get { return @"Patient care problem query"; } }

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

        public HL7V25TriggerEventQRY_PC4(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);

        }
    }
}
