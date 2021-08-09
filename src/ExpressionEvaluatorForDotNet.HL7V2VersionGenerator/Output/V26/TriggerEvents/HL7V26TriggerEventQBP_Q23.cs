using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventQBP_Q23
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentQPD qpd{ get; init; }
public HL7V26SegmentRCP rcp{ get; init; }
public HL7V26SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QBP_Q23"; } }
        public string MessageStructureId { get { return @"QBP_Q23"; } }
        public string EventDescription { get { return @"Get Corresponding Identifiers Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
"CH_05",

                    };
            }
        }

        public HL7V26TriggerEventQBP_Q23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.qpd = new HL7V26SegmentQPD(this.message);
this.rcp = new HL7V26SegmentRCP(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
