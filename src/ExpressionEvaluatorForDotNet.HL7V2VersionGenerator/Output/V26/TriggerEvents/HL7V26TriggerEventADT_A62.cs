using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventADT_A62
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentEVN evn;
private readonly HL7V26SegmentPID pid;
private readonly HL7V26SegmentPD1 pd1;
private readonly HL7V26SegmentROL rol;
private readonly HL7V26SegmentPV1 pv1;
private readonly HL7V26SegmentROL rol;
private readonly HL7V26SegmentPV2 pv2;


        public string Id { get { return @"ADT_A62"; } }
        public string MessageStructureId { get { return @"ADT_A62"; } }
        public string EventDescription { get { return @"Cancel Change Consulting Doctor"; } }

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

        public HL7V26TriggerEventADT_A62(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pd1 = new HL7V26SegmentPD1(this.message);
this.rol = new HL7V26SegmentROL(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.rol = new HL7V26SegmentROL(this.message);
this.pv2 = new HL7V26SegmentPV2(this.message);

        }
    }
}
