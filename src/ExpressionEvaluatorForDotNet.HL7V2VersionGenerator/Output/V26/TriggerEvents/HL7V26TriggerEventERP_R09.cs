using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventERP_R09
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentMSA msa{ get; init; }
public HL7V26SegmentERR err{ get; init; }
public HL7V26SegmentQAK qak{ get; init; }
public HL7V26SegmentERQ erq{ get; init; }
public HL7V26SegmentDSC dsc{ get; init; }


        public string Id { get { return @"ERP_R09"; } }
        public string MessageStructureId { get { return @"ERP_R09"; } }
        public string EventDescription { get { return @"Event Replay Response"; } }

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

        public HL7V26TriggerEventERP_R09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.erq = new HL7V26SegmentERQ(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
