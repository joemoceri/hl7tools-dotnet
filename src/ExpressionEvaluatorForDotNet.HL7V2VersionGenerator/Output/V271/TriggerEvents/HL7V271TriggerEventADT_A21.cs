using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventADT_A21
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentEVN evn{get; init;}
public HL7V271SegmentPID pid{get; init;}
public HL7V271SegmentPD1 pd1{get; init;}
public HL7V271SegmentPV1 pv1{get; init;}
public HL7V271SegmentPV2 pv2{get; init;}
public HL7V271SegmentDB1 db1{get; init;}
public HL7V271SegmentOBX obx{get; init;}


        public string Id { get { return @"ADT_A21"; } }
        public string MessageStructureId { get { return @"ADT_A21"; } }
        public string EventDescription { get { return @"Patient goes on a ""leave of absence"""; } }

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

        public HL7V271TriggerEventADT_A21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.pv2 = new HL7V271SegmentPV2(this.message);
this.db1 = new HL7V271SegmentDB1(this.message);
this.obx = new HL7V271SegmentOBX(this.message);

        }
    }
}
