using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventOSQ_Q06
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentQRD qrd{ get; init; }
public HL7V25SegmentQRF qrf{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


        public string Id { get { return @"OSQ_Q06"; } }
        public string MessageStructureId { get { return @"OSQ_Q06"; } }
        public string EventDescription { get { return @"Query for Order Status"; } }

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

        public HL7V25TriggerEventOSQ_Q06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
