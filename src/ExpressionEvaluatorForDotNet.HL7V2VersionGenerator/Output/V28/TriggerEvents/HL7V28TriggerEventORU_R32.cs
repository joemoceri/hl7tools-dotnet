using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventORU_R32
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentPID pid;
private readonly HL7V28SegmentPD1 pd1;
private readonly HL7V28SegmentPRT prt;
private readonly HL7V28SegmentARV arv;
private readonly HL7V28SegmentORC orc;
private readonly HL7V28SegmentPRT prt;
private readonly HL7V28SegmentOBR obr;
private readonly HL7V28SegmentNTE nte;
private readonly HL7V28SegmentPRT prt;


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

        public HL7V28TriggerEventORU_R32(HL7V2Message message)
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
