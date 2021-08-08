using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventADT_A15
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEVN evn;
private readonly HL7V24SegmentPID pid;
private readonly HL7V24SegmentPD1 pd1;
private readonly HL7V24SegmentROL rol;
private readonly HL7V24SegmentPV1 pv1;
private readonly HL7V24SegmentPV2 pv2;
private readonly HL7V24SegmentROL rol;
private readonly HL7V24SegmentDB1 db1;
private readonly HL7V24SegmentOBX obx;
private readonly HL7V24SegmentDG1 dg1;


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

        public HL7V24TriggerEventADT_A15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.rol = new HL7V24SegmentROL(this.message);
this.pv1 = new HL7V24SegmentPV1(this.message);
this.pv2 = new HL7V24SegmentPV2(this.message);
this.rol = new HL7V24SegmentROL(this.message);
this.db1 = new HL7V24SegmentDB1(this.message);
this.obx = new HL7V24SegmentOBX(this.message);
this.dg1 = new HL7V24SegmentDG1(this.message);

        }
    }
}
