using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A03
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentEVN evn{ get; init; }
public HL7V251SegmentPID pid{ get; init; }
public HL7V251SegmentPD1 pd1{ get; init; }
public HL7V251SegmentROL rol{ get; init; }
public HL7V251SegmentNK1 nk1{ get; init; }
public HL7V251SegmentPV1 pv1{ get; init; }
public HL7V251SegmentPV2 pv2{ get; init; }
public HL7V251SegmentROL rol{ get; init; }
public HL7V251SegmentDB1 db1{ get; init; }
public HL7V251SegmentAL1 al1{ get; init; }
public HL7V251SegmentDG1 dg1{ get; init; }
public HL7V251SegmentDRG drg{ get; init; }
public HL7V251SegmentOBX obx{ get; init; }
public HL7V251SegmentGT1 gt1{ get; init; }
public HL7V251SegmentACC acc{ get; init; }
public HL7V251SegmentPDA pda{ get; init; }


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

        public HL7V251TriggerEventADT_A03(HL7V2Message message)
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
this.al1 = new HL7V251SegmentAL1(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.obx = new HL7V251SegmentOBX(this.message);
this.gt1 = new HL7V251SegmentGT1(this.message);
this.acc = new HL7V251SegmentACC(this.message);
this.pda = new HL7V251SegmentPDA(this.message);

        }
    }
}
