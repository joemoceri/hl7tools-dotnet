using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMDM_T04
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEVN evn;
private readonly HL7V24SegmentPID pid;
private readonly HL7V24SegmentPV1 pv1;
private readonly HL7V24SegmentTXA txa;
private readonly HL7V24SegmentOBX obx;


        public string Id { get { return @"MDM_T04"; } }
        public string MessageStructureId { get { return @"MDM_T04"; } }
        public string EventDescription { get { return @"Document status change notification and content"; } }

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

        public HL7V24TriggerEventMDM_T04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.txa = new HL7V24SegmentTXA(this.message);
this.obx = new HL7V24SegmentOBX(this.message);

        }
    }
}
