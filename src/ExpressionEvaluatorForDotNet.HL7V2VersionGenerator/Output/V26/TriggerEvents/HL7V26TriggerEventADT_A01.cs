using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventADT_A01
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentEVN evn;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentPD1 pd1;
public readonly HL7V26SegmentARV arv;
public readonly HL7V26SegmentROL rol;
public readonly HL7V26SegmentNK1 nk1;
public readonly HL7V26SegmentPV1 pv1;
public readonly HL7V26SegmentPV2 pv2;
public readonly HL7V26SegmentARV arv;
public readonly HL7V26SegmentROL rol;
public readonly HL7V26SegmentDB1 db1;
public readonly HL7V26SegmentOBX obx;
public readonly HL7V26SegmentAL1 al1;
public readonly HL7V26SegmentDG1 dg1;
public readonly HL7V26SegmentDRG drg;
public readonly HL7V26SegmentGT1 gt1;
public readonly HL7V26SegmentACC acc;
public readonly HL7V26SegmentUB1 ub1;
public readonly HL7V26SegmentUB2 ub2;
public readonly HL7V26SegmentPDA pda;


        public string Id { get { return @"ADT_A01"; } }
        public string MessageStructureId { get { return @"ADT_A01"; } }
        public string EventDescription { get { return @"Admit/Visit Notification"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
                    };
            }
        }

        public HL7V26TriggerEventADT_A01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pd1 = new HL7V26SegmentPD1(this.message);
this.arv = new HL7V26SegmentARV(this.message);
this.rol = new HL7V26SegmentROL(this.message);
this.nk1 = new HL7V26SegmentNK1(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.pv2 = new HL7V26SegmentPV2(this.message);
this.arv = new HL7V26SegmentARV(this.message);
this.rol = new HL7V26SegmentROL(this.message);
this.db1 = new HL7V26SegmentDB1(this.message);
this.obx = new HL7V26SegmentOBX(this.message);
this.al1 = new HL7V26SegmentAL1(this.message);
this.dg1 = new HL7V26SegmentDG1(this.message);
this.drg = new HL7V26SegmentDRG(this.message);
this.gt1 = new HL7V26SegmentGT1(this.message);
this.acc = new HL7V26SegmentACC(this.message);
this.ub1 = new HL7V26SegmentUB1(this.message);
this.ub2 = new HL7V26SegmentUB2(this.message);
this.pda = new HL7V26SegmentPDA(this.message);

        }
    }
}
