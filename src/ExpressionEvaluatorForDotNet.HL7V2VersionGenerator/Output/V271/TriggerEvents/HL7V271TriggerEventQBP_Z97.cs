using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventQBP_Z97
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentQPD qpd{ get; init; }
public HL7V271SegmentHxx hxx{ get; init; }
public HL7V271SegmentRCP rcp{ get; init; }
public HL7V271SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QBP_Z97"; } }
        public string MessageStructureId { get { return @"QBP_Z97"; } }
        public string EventDescription { get { return @"Dispense History"; } }

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

        public HL7V271TriggerEventQBP_Z97(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.qpd = new HL7V271SegmentQPD(this.message);
this.hxx = new HL7V271SegmentHxx(this.message);
this.rcp = new HL7V271SegmentRCP(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
