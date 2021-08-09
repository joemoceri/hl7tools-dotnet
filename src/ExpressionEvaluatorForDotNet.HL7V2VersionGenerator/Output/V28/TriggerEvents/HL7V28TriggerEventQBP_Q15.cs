using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventQBP_Q15
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentQPD qpd{ get; init; }
public HL7V28SegmentHxx hxx{ get; init; }
public HL7V28SegmentRCP rcp{ get; init; }
public HL7V28SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QBP_Q15"; } }
        public string MessageStructureId { get { return @"QBP_Q15"; } }
        public string EventDescription { get { return @"Query by parameter requesting an RDY display response"; } }

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

        public HL7V28TriggerEventQBP_Q15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);
this.hxx = new HL7V28SegmentHxx(this.message);
this.rcp = new HL7V28SegmentRCP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
