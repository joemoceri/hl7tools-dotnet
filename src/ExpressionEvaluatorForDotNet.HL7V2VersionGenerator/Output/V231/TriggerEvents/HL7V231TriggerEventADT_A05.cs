using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A05
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentEVN evn;
public readonly HL7V231SegmentPID pid;
public readonly HL7V231SegmentPD1 pd1;
public readonly HL7V231SegmentNK1 nk1;
public readonly HL7V231SegmentPV1 pv1;
public readonly HL7V231SegmentPV2 pv2;
public readonly HL7V231SegmentDB1 db1;
public readonly HL7V231SegmentOBX obx;
public readonly HL7V231SegmentAL1 al1;
public readonly HL7V231SegmentDG1 dg1;
public readonly HL7V231SegmentDRG drg;
public readonly HL7V231SegmentGT1 gt1;
public readonly HL7V231SegmentACC acc;
public readonly HL7V231SegmentUB1 ub1;
public readonly HL7V231SegmentUB2 ub2;


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

        public HL7V231TriggerEventADT_A05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.nk1 = new HL7V231SegmentNK1(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.pv2 = new HL7V231SegmentPV2(this.message);
this.db1 = new HL7V231SegmentDB1(this.message);
this.obx = new HL7V231SegmentOBX(this.message);
this.al1 = new HL7V231SegmentAL1(this.message);
this.dg1 = new HL7V231SegmentDG1(this.message);
this.drg = new HL7V231SegmentDRG(this.message);
this.gt1 = new HL7V231SegmentGT1(this.message);
this.acc = new HL7V231SegmentACC(this.message);
this.ub1 = new HL7V231SegmentUB1(this.message);
this.ub2 = new HL7V231SegmentUB2(this.message);

        }
    }
}
