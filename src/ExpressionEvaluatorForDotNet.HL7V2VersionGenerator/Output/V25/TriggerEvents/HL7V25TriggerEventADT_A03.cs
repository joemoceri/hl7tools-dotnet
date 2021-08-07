using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventADT_A03
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentEVN evn;
public readonly HL7V25SegmentPID pid;
public readonly HL7V25SegmentPD1 pd1;
public readonly HL7V25SegmentROL rol;
public readonly HL7V25SegmentNK1 nk1;
public readonly HL7V25SegmentPV1 pv1;
public readonly HL7V25SegmentPV2 pv2;
public readonly HL7V25SegmentROL rol;
public readonly HL7V25SegmentDB1 db1;
public readonly HL7V25SegmentAL1 al1;
public readonly HL7V25SegmentDG1 dg1;
public readonly HL7V25SegmentDRG drg;
public readonly HL7V25SegmentOBX obx;
public readonly HL7V25SegmentGT1 gt1;
public readonly HL7V25SegmentACC acc;
public readonly HL7V25SegmentPDA pda;


        public string Id { get { return @"ADT_A03"; } }
        public string MessageStructureId { get { return @"ADT_A03"; } }
        public string EventDescription { get { return @"Discharge/End Visit"; } }

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

        public HL7V25TriggerEventADT_A03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.rol = new HL7V25SegmentROL(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.pv2 = new HL7V25SegmentPV2(this.message);
this.rol = new HL7V25SegmentROL(this.message);
this.db1 = new HL7V25SegmentDB1(this.message);
this.al1 = new HL7V25SegmentAL1(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.drg = new HL7V25SegmentDRG(this.message);
this.obx = new HL7V25SegmentOBX(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);
this.acc = new HL7V25SegmentACC(this.message);
this.pda = new HL7V25SegmentPDA(this.message);

        }
    }
}