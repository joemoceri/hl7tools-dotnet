using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventADT_A16
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentEVN evn;
public readonly HL7V22SegmentPID pid;
public readonly HL7V22SegmentPV1 pv1;
public readonly HL7V22SegmentPV2 pv2;
public readonly HL7V22SegmentOBX obx;
public readonly HL7V22SegmentDG1 dg1;


        public string Id { get { return @"ADT_A16"; } }
        public string MessageStructureId { get { return @"ADT_A16"; } }
        public string EventDescription { get { return @"Pending Discharge"; } }

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

        public HL7V22TriggerEventADT_A16(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.pv1 = new HL7V22SegmentPV1(this.message);
this.pv2 = new HL7V22SegmentPV2(this.message);
this.obx = new HL7V22SegmentOBX(this.message);
this.dg1 = new HL7V22SegmentDG1(this.message);

        }
    }
}
