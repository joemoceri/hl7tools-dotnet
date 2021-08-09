using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventADT_A28
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentEVN evn{ get; init; }
public HL7V23SegmentPID pid{ get; init; }
public HL7V23SegmentPD1 pd1{ get; init; }
public HL7V23SegmentNK1 nk1{ get; init; }
public HL7V23SegmentPV1 pv1{ get; init; }
public HL7V23SegmentPV2 pv2{ get; init; }
public HL7V23SegmentDB1 db1{ get; init; }
public HL7V23SegmentOBX obx{ get; init; }
public HL7V23SegmentAL1 al1{ get; init; }
public HL7V23SegmentDG1 dg1{ get; init; }
public HL7V23SegmentDRG drg{ get; init; }
public HL7V23SegmentGT1 gt1{ get; init; }
public HL7V23SegmentACC acc{ get; init; }
public HL7V23SegmentUB1 ub1{ get; init; }
public HL7V23SegmentUB2 ub2{ get; init; }


        public string Id { get { return @"ADT_A28"; } }
        public string MessageStructureId { get { return @"ADT_A28"; } }
        public string EventDescription { get { return @"Add person information"; } }

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

        public HL7V23TriggerEventADT_A28(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.evn = new HL7V23SegmentEVN(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.pd1 = new HL7V23SegmentPD1(this.message);
this.nk1 = new HL7V23SegmentNK1(this.message);
this.pv1 = new HL7V23SegmentPV1(this.message);
this.pv2 = new HL7V23SegmentPV2(this.message);
this.db1 = new HL7V23SegmentDB1(this.message);
this.obx = new HL7V23SegmentOBX(this.message);
this.al1 = new HL7V23SegmentAL1(this.message);
this.dg1 = new HL7V23SegmentDG1(this.message);
this.drg = new HL7V23SegmentDRG(this.message);
this.gt1 = new HL7V23SegmentGT1(this.message);
this.acc = new HL7V23SegmentACC(this.message);
this.ub1 = new HL7V23SegmentUB1(this.message);
this.ub2 = new HL7V23SegmentUB2(this.message);

        }
    }
}
