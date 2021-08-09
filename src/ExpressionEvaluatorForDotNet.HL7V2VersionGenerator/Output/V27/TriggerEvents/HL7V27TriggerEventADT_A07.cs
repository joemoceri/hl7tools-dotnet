using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventADT_A07
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentEVN evn{get; init;}
public HL7V27SegmentPID pid{get; init;}
public HL7V27SegmentPD1 pd1{get; init;}
public HL7V27SegmentARV arv{get; init;}
public HL7V27SegmentROL rol{get; init;}
public HL7V27SegmentMRG mrg{get; init;}
public HL7V27SegmentNK1 nk1{get; init;}
public HL7V27SegmentPV1 pv1{get; init;}
public HL7V27SegmentPV2 pv2{get; init;}
public HL7V27SegmentARV arv{get; init;}
public HL7V27SegmentROL rol{get; init;}
public HL7V27SegmentDB1 db1{get; init;}
public HL7V27SegmentOBX obx{get; init;}
public HL7V27SegmentAL1 al1{get; init;}
public HL7V27SegmentDG1 dg1{get; init;}
public HL7V27SegmentDRG drg{get; init;}
public HL7V27SegmentGT1 gt1{get; init;}
public HL7V27SegmentACC acc{get; init;}
public HL7V27SegmentUB1 ub1{get; init;}
public HL7V27SegmentUB2 ub2{get; init;}


        public string Id { get { return @"ADT_A07"; } }
        public string MessageStructureId { get { return @"ADT_A07"; } }
        public string EventDescription { get { return @"Change an inpatient to an outpatient"; } }

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

        public HL7V27TriggerEventADT_A07(HL7V2Message message)
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
this.mrg = new HL7V27SegmentMRG(this.message);
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
