using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventADT_A03
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentEVN evn{ get; init; }
public HL7V26SegmentPID pid{ get; init; }
public HL7V26SegmentPD1 pd1{ get; init; }
public HL7V26SegmentARV arv{ get; init; }
public HL7V26SegmentROL rol{ get; init; }
public HL7V26SegmentNK1 nk1{ get; init; }
public HL7V26SegmentPV1 pv1{ get; init; }
public HL7V26SegmentPV2 pv2{ get; init; }
public HL7V26SegmentARV arv{ get; init; }
public HL7V26SegmentROL rol{ get; init; }
public HL7V26SegmentDB1 db1{ get; init; }
public HL7V26SegmentAL1 al1{ get; init; }
public HL7V26SegmentDG1 dg1{ get; init; }
public HL7V26SegmentDRG drg{ get; init; }
public HL7V26SegmentOBX obx{ get; init; }
public HL7V26SegmentGT1 gt1{ get; init; }
public HL7V26SegmentACC acc{ get; init; }
public HL7V26SegmentPDA pda{ get; init; }


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

        public HL7V26TriggerEventADT_A03(HL7V2Message message)
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
this.al1 = new HL7V26SegmentAL1(this.message);
this.dg1 = new HL7V26SegmentDG1(this.message);
this.drg = new HL7V26SegmentDRG(this.message);
this.obx = new HL7V26SegmentOBX(this.message);
this.gt1 = new HL7V26SegmentGT1(this.message);
this.acc = new HL7V26SegmentACC(this.message);
this.pda = new HL7V26SegmentPDA(this.message);

        }
    }
}
