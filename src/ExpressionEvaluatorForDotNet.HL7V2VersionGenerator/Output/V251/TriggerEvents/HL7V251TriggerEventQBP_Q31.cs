using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQBP_Q31
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentQPD qpd{ get; init; }
public HL7V251SegmentRCP rcp{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QBP_Q31"; } }
        public string MessageStructureId { get { return @"QBP_Q31"; } }
        public string EventDescription { get { return @"Dispense History Query"; } }

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

        public HL7V251TriggerEventQBP_Q31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qpd = new HL7V251SegmentQPD(this.message);
this.rcp = new HL7V251SegmentRCP(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
