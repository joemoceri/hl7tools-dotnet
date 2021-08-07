using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A23
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentEVN evn;
public readonly HL7V231SegmentPID pid;
public readonly HL7V231SegmentPD1 pd1;
public readonly HL7V231SegmentPV1 pv1;
public readonly HL7V231SegmentPV2 pv2;
public readonly HL7V231SegmentDB1 db1;
public readonly HL7V231SegmentOBX obx;


        public string Id { get { return @"ADT_A23"; } }
        public string MessageStructureId { get { return @"ADT_A23"; } }
        public string EventDescription { get { return @"Delete a patient record"; } }

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

        public HL7V231TriggerEventADT_A23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.pv2 = new HL7V231SegmentPV2(this.message);
this.db1 = new HL7V231SegmentDB1(this.message);
this.obx = new HL7V231SegmentOBX(this.message);

        }
    }
}
