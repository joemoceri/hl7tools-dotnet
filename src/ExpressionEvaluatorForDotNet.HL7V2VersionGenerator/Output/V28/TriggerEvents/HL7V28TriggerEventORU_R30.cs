using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventORU_R30
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentPID pid;
public readonly HL7V28SegmentPD1 pd1;
public readonly HL7V28SegmentPRT prt;
public readonly HL7V28SegmentARV arv;
public readonly HL7V28SegmentORC orc;
public readonly HL7V28SegmentPRT prt;
public readonly HL7V28SegmentOBR obr;
public readonly HL7V28SegmentNTE nte;
public readonly HL7V28SegmentPRT prt;


        public string Id { get { return @"ORU_R30"; } }
        public string MessageStructureId { get { return @"ORU_R30"; } }
        public string EventDescription { get { return @"Unsolicited Point-Of-Care Observation Message Without Existing Order - Place an Order"; } }

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

        public HL7V28TriggerEventORU_R30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pd1 = new HL7V28SegmentPD1(this.message);
this.prt = new HL7V28SegmentPRT(this.message);
this.arv = new HL7V28SegmentARV(this.message);
this.orc = new HL7V28SegmentORC(this.message);
this.prt = new HL7V28SegmentPRT(this.message);
this.obr = new HL7V28SegmentOBR(this.message);
this.nte = new HL7V28SegmentNTE(this.message);
this.prt = new HL7V28SegmentPRT(this.message);

        }
    }
}
