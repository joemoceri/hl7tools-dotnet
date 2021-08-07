using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventOSQ_Q06
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentQRD qrd;
public readonly HL7V25SegmentQRF qrf;
public readonly HL7V25SegmentDSC dsc;


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
