using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventOSR_Q06
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentMSA msa{ get; init; }
public HL7V23SegmentERR err{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }
public HL7V23SegmentQRD qrd{ get; init; }
public HL7V23SegmentQRF qrf{ get; init; }
public HL7V23SegmentDSC dsc{ get; init; }


        public string Id { get { return @"OSR_Q06"; } }
        public string MessageStructureId { get { return @"OSR_Q06"; } }
        public string EventDescription { get { return @"Query response for order status"; } }

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

        public HL7V23TriggerEventOSR_Q06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.nte = new HL7V23SegmentNTE(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
