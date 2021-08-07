using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventADT_A27
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentEVN evn;
public readonly HL7V28SegmentPID pid;
public readonly HL7V28SegmentPD1 pd1;
public readonly HL7V28SegmentPV1 pv1;
public readonly HL7V28SegmentPV2 pv2;
public readonly HL7V28SegmentDB1 db1;
public readonly HL7V28SegmentOBX obx;


        public string Id { get { return @"ADT_A27"; } }
        public string MessageStructureId { get { return @"ADT_A27"; } }
        public string EventDescription { get { return @"Cancel pending admit"; } }

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

        public HL7V28TriggerEventADT_A27(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pd1 = new HL7V28SegmentPD1(this.message);
this.pv1 = new HL7V28SegmentPV1(this.message);
this.pv2 = new HL7V28SegmentPV2(this.message);
this.db1 = new HL7V28SegmentDB1(this.message);
this.obx = new HL7V28SegmentOBX(this.message);

        }
    }
}
