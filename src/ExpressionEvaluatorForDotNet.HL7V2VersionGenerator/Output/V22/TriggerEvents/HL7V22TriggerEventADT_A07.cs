using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventADT_A07
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentEVN evn;
public readonly HL7V22SegmentPID pid;
public readonly HL7V22SegmentMRG mrg;
public readonly HL7V22SegmentNK1 nk1;
public readonly HL7V22SegmentPV1 pv1;
public readonly HL7V22SegmentPV2 pv2;
public readonly HL7V22SegmentOBX obx;
public readonly HL7V22SegmentAL1 al1;
public readonly HL7V22SegmentDG1 dg1;
public readonly HL7V22SegmentPR1 pr1;
public readonly HL7V22SegmentGT1 gt1;
public readonly HL7V22SegmentACC acc;
public readonly HL7V22SegmentUB1 ub1;
public readonly HL7V22SegmentUB2 ub2;


        public string Id { get { return @"ADT_A07"; } }
        public string MessageStructureId { get { return @"ADT_A07"; } }
        public string EventDescription { get { return @"Transfer an Inpatient to Outpatient"; } }

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

        public HL7V22TriggerEventADT_A07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.mrg = new HL7V22SegmentMRG(this.message);
this.nk1 = new HL7V22SegmentNK1(this.message);
this.pv1 = new HL7V22SegmentPV1(this.message);
this.pv2 = new HL7V22SegmentPV2(this.message);
this.obx = new HL7V22SegmentOBX(this.message);
this.al1 = new HL7V22SegmentAL1(this.message);
this.dg1 = new HL7V22SegmentDG1(this.message);
this.pr1 = new HL7V22SegmentPR1(this.message);
this.gt1 = new HL7V22SegmentGT1(this.message);
this.acc = new HL7V22SegmentACC(this.message);
this.ub1 = new HL7V22SegmentUB1(this.message);
this.ub2 = new HL7V22SegmentUB2(this.message);

        }
    }
}
