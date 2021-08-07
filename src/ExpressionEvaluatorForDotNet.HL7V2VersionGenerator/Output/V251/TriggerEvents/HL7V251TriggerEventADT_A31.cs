using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A31
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEVN evn;
public readonly HL7V251SegmentPID pid;
public readonly HL7V251SegmentPD1 pd1;
public readonly HL7V251SegmentROL rol;
public readonly HL7V251SegmentNK1 nk1;
public readonly HL7V251SegmentPV1 pv1;
public readonly HL7V251SegmentPV2 pv2;
public readonly HL7V251SegmentROL rol;
public readonly HL7V251SegmentDB1 db1;
public readonly HL7V251SegmentOBX obx;
public readonly HL7V251SegmentAL1 al1;
public readonly HL7V251SegmentDG1 dg1;
public readonly HL7V251SegmentDRG drg;
public readonly HL7V251SegmentGT1 gt1;
public readonly HL7V251SegmentACC acc;
public readonly HL7V251SegmentUB1 ub1;
public readonly HL7V251SegmentUB2 ub2;


        public string Id { get { return @"ADT_A31"; } }
        public string MessageStructureId { get { return @"ADT_A31"; } }
        public string EventDescription { get { return @"Update Person Information"; } }

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

        public HL7V251TriggerEventADT_A31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.rol = new HL7V251SegmentROL(this.message);
this.nk1 = new HL7V251SegmentNK1(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.pv2 = new HL7V251SegmentPV2(this.message);
this.rol = new HL7V251SegmentROL(this.message);
this.db1 = new HL7V251SegmentDB1(this.message);
this.obx = new HL7V251SegmentOBX(this.message);
this.al1 = new HL7V251SegmentAL1(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.gt1 = new HL7V251SegmentGT1(this.message);
this.acc = new HL7V251SegmentACC(this.message);
this.ub1 = new HL7V251SegmentUB1(this.message);
this.ub2 = new HL7V251SegmentUB2(this.message);

        }
    }
}
