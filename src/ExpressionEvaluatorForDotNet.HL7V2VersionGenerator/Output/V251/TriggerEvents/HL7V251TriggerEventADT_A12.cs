using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A12
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEVN evn;
public readonly HL7V251SegmentPID pid;
public readonly HL7V251SegmentPD1 pd1;
public readonly HL7V251SegmentPV1 pv1;
public readonly HL7V251SegmentPV2 pv2;
public readonly HL7V251SegmentDB1 db1;
public readonly HL7V251SegmentOBX obx;
public readonly HL7V251SegmentDG1 dg1;


        public string Id { get { return @"ADT_A12"; } }
        public string MessageStructureId { get { return @"ADT_A12"; } }
        public string EventDescription { get { return @"Cancel Transfer"; } }

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

        public HL7V251TriggerEventADT_A12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.pv2 = new HL7V251SegmentPV2(this.message);
this.db1 = new HL7V251SegmentDB1(this.message);
this.obx = new HL7V251SegmentOBX(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);

        }
    }
}
