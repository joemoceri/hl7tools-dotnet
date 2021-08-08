using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventORU_R32
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentPID pid;
private readonly HL7V25SegmentPD1 pd1;
private readonly HL7V25SegmentORC orc;
private readonly HL7V25SegmentOBR obr;
private readonly HL7V25SegmentNTE nte;


        public string Id { get { return @"ORU_R32"; } }
        public string MessageStructureId { get { return @"ORU_R32"; } }
        public string EventDescription { get { return @"Unsolicited Pre-Ordered Point-Of-Care Observation"; } }

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

        public HL7V25TriggerEventORU_R32(HL7V2Message message)
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
