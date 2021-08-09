using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventADT_A06
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentEVN evn{ get; init; }
public HL7V271SegmentPID pid{ get; init; }
public HL7V271SegmentPD1 pd1{ get; init; }
public HL7V271SegmentARV arv{ get; init; }
public HL7V271SegmentROL rol{ get; init; }
public HL7V271SegmentMRG mrg{ get; init; }
public HL7V271SegmentNK1 nk1{ get; init; }
public HL7V271SegmentPV1 pv1{ get; init; }
public HL7V271SegmentPV2 pv2{ get; init; }
public HL7V271SegmentARV arv{ get; init; }
public HL7V271SegmentROL rol{ get; init; }
public HL7V271SegmentDB1 db1{ get; init; }
public HL7V271SegmentOBX obx{ get; init; }
public HL7V271SegmentAL1 al1{ get; init; }
public HL7V271SegmentDG1 dg1{ get; init; }
public HL7V271SegmentDRG drg{ get; init; }
public HL7V271SegmentGT1 gt1{ get; init; }
public HL7V271SegmentACC acc{ get; init; }
public HL7V271SegmentUB1 ub1{ get; init; }
public HL7V271SegmentUB2 ub2{ get; init; }


        public string Id { get { return @"ADT_A06"; } }
        public string MessageStructureId { get { return @"ADT_A06"; } }
        public string EventDescription { get { return @"Change an outpatient to an inpatient"; } }

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

        public HL7V271TriggerEventADT_A06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.arv = new HL7V271SegmentARV(this.message);
this.rol = new HL7V271SegmentROL(this.message);
this.mrg = new HL7V271SegmentMRG(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.pv2 = new HL7V271SegmentPV2(this.message);
this.arv = new HL7V271SegmentARV(this.message);
this.rol = new HL7V271SegmentROL(this.message);
this.db1 = new HL7V271SegmentDB1(this.message);
this.obx = new HL7V271SegmentOBX(this.message);
this.al1 = new HL7V271SegmentAL1(this.message);
this.dg1 = new HL7V271SegmentDG1(this.message);
this.drg = new HL7V271SegmentDRG(this.message);
this.gt1 = new HL7V271SegmentGT1(this.message);
this.acc = new HL7V271SegmentACC(this.message);
this.ub1 = new HL7V271SegmentUB1(this.message);
this.ub2 = new HL7V271SegmentUB2(this.message);

        }
    }
}
