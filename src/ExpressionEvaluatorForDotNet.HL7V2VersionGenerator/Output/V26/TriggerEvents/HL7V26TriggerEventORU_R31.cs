using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventORU_R31
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentPD1 pd1;
public readonly HL7V26SegmentOBX obx;
public readonly HL7V26SegmentORC orc;
public readonly HL7V26SegmentOBR obr;
public readonly HL7V26SegmentNTE nte;
public readonly HL7V26SegmentROL rol;


        public string Id { get { return @"ORU_R31"; } }
        public string MessageStructureId { get { return @"ORU_R31"; } }
        public string EventDescription { get { return @"Unsolicited New Point-Of-Care Observation Message – Search for an Order"; } }

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

        public HL7V26TriggerEventORU_R31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pd1 = new HL7V26SegmentPD1(this.message);
this.obx = new HL7V26SegmentOBX(this.message);
this.orc = new HL7V26SegmentORC(this.message);
this.obr = new HL7V26SegmentOBR(this.message);
this.nte = new HL7V26SegmentNTE(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}
