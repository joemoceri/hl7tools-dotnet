using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventBRP_O30
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentMSA msa{ get; init; }
public HL7V28SegmentERR err{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentNTE nte{ get; init; }


        public string Id { get { return @"BRP_O30"; } }
        public string MessageStructureId { get { return @"BRP_O30"; } }
        public string EventDescription { get { return @"Blood product dispense status acknowledgment"; } }

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

        public HL7V28TriggerEventBRP_O30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
