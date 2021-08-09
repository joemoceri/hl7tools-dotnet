using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventORU_R30
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentPID pid{ get; init; }
public HL7V25SegmentPD1 pd1{ get; init; }
public HL7V25SegmentORC orc{ get; init; }
public HL7V25SegmentOBR obr{ get; init; }
public HL7V25SegmentNTE nte{ get; init; }


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

        public HL7V25TriggerEventORU_R30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.orc = new HL7V25SegmentORC(this.message);
this.obr = new HL7V25SegmentOBR(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
