using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventORU_R30
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentPID pid{ get; init; }
public HL7V251SegmentPD1 pd1{ get; init; }
public HL7V251SegmentORC orc{ get; init; }
public HL7V251SegmentOBR obr{ get; init; }
public HL7V251SegmentNTE nte{ get; init; }


        public string Id { get { return @"ORU_R30"; } }
        public string MessageStructureId { get { return @"ORU_R30"; } }
        public string EventDescription { get { return @"Unsolicited Point-Of-Care Observation Message Without Existing Order – Place An Order"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V251TriggerEventORU_R30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.orc = new HL7V251SegmentORC(this.message);
this.obr = new HL7V251SegmentOBR(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
