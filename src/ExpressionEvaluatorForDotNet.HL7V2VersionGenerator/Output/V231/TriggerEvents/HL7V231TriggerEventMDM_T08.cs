using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMDM_T08
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentEVN evn;
private readonly HL7V231SegmentPID pid;
private readonly HL7V231SegmentPV1 pv1;
private readonly HL7V231SegmentTXA txa;
private readonly HL7V231SegmentOBX obx;


        public string Id { get { return @"MDM_T08"; } }
        public string MessageStructureId { get { return @"MDM_T08"; } }
        public string EventDescription { get { return @"Document edit notification and content"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V231TriggerEventMDM_T08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.txa = new HL7V231SegmentTXA(this.message);
this.obx = new HL7V231SegmentOBX(this.message);

        }
    }
}
