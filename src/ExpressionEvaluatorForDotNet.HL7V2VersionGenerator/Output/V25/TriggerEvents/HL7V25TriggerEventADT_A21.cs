using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventADT_A21
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentEVN evn;
private readonly HL7V25SegmentPID pid;
private readonly HL7V25SegmentPD1 pd1;
private readonly HL7V25SegmentPV1 pv1;
private readonly HL7V25SegmentPV2 pv2;
private readonly HL7V25SegmentDB1 db1;
private readonly HL7V25SegmentOBX obx;


        public string Id { get { return @"ADT_A21"; } }
        public string MessageStructureId { get { return @"ADT_A21"; } }
        public string EventDescription { get { return @"Patient Goes on a Leave of Absence"; } }

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

        public HL7V25TriggerEventADT_A21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.pv2 = new HL7V25SegmentPV2(this.message);
this.db1 = new HL7V25SegmentDB1(this.message);
this.obx = new HL7V25SegmentOBX(this.message);

        }
    }
}
