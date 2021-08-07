using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventADT_A05
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentEVN evn;
public readonly HL7V27SegmentPID pid;
public readonly HL7V27SegmentPD1 pd1;
public readonly HL7V27SegmentARV arv;
public readonly HL7V27SegmentROL rol;
public readonly HL7V27SegmentNK1 nk1;
public readonly HL7V27SegmentPV1 pv1;
public readonly HL7V27SegmentPV2 pv2;
public readonly HL7V27SegmentARV arv;
public readonly HL7V27SegmentROL rol;
public readonly HL7V27SegmentDB1 db1;
public readonly HL7V27SegmentOBX obx;
public readonly HL7V27SegmentAL1 al1;
public readonly HL7V27SegmentDG1 dg1;
public readonly HL7V27SegmentDRG drg;
public readonly HL7V27SegmentGT1 gt1;
public readonly HL7V27SegmentACC acc;
public readonly HL7V27SegmentUB1 ub1;
public readonly HL7V27SegmentUB2 ub2;


        public string Id { get { return @"ADT_A05"; } }
        public string MessageStructureId { get { return @"ADT_A05"; } }
        public string EventDescription { get { return @"Pre-admit a patient"; } }

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

        public HL7V27TriggerEventADT_A05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.arv = new HL7V27SegmentARV(this.message);
this.rol = new HL7V27SegmentROL(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.pv1 = new HL7V27SegmentPV1(this.message);
this.pv2 = new HL7V27SegmentPV2(this.message);
this.arv = new HL7V27SegmentARV(this.message);
this.rol = new HL7V27SegmentROL(this.message);
this.db1 = new HL7V27SegmentDB1(this.message);
this.obx = new HL7V27SegmentOBX(this.message);
this.al1 = new HL7V27SegmentAL1(this.message);
this.dg1 = new HL7V27SegmentDG1(this.message);
this.drg = new HL7V27SegmentDRG(this.message);
this.gt1 = new HL7V27SegmentGT1(this.message);
this.acc = new HL7V27SegmentACC(this.message);
this.ub1 = new HL7V27SegmentUB1(this.message);
this.ub2 = new HL7V27SegmentUB2(this.message);

        }
    }
}