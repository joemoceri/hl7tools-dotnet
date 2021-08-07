using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventADT_A15
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentEVN evn;
public readonly HL7V23SegmentPID pid;
public readonly HL7V23SegmentPD1 pd1;
public readonly HL7V23SegmentPV1 pv1;
public readonly HL7V23SegmentPV2 pv2;
public readonly HL7V23SegmentDB1 db1;
public readonly HL7V23SegmentOBX obx;
public readonly HL7V23SegmentDG1 dg1;


        public string Id { get { return @"ADT_A15"; } }
        public string MessageStructureId { get { return @"ADT_A15"; } }
        public string EventDescription { get { return @"Pending transfer"; } }

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

        public HL7V23TriggerEventADT_A15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.evn = new HL7V23SegmentEVN(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.pd1 = new HL7V23SegmentPD1(this.message);
this.pv1 = new HL7V23SegmentPV1(this.message);
this.pv2 = new HL7V23SegmentPV2(this.message);
this.db1 = new HL7V23SegmentDB1(this.message);
this.obx = new HL7V23SegmentOBX(this.message);
this.dg1 = new HL7V23SegmentDG1(this.message);

        }
    }
}
