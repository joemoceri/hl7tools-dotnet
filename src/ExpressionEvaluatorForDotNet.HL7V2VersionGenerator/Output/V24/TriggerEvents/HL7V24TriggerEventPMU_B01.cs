using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPMU_B01
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEVN evn;
private readonly HL7V24SegmentSTF stf;
private readonly HL7V24SegmentPRA pra;
private readonly HL7V24SegmentORG org;
private readonly HL7V24SegmentAFF aff;
private readonly HL7V24SegmentLAN lan;
private readonly HL7V24SegmentEDU edu;


        public string Id { get { return @"PMU_B01"; } }
        public string MessageStructureId { get { return @"PMU_B01"; } }
        public string EventDescription { get { return @"Add personnel record"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V24TriggerEventPMU_B01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.stf = new HL7V24SegmentSTF(this.message);
this.pra = new HL7V24SegmentPRA(this.message);
this.org = new HL7V24SegmentORG(this.message);
this.aff = new HL7V24SegmentAFF(this.message);
this.lan = new HL7V24SegmentLAN(this.message);
this.edu = new HL7V24SegmentEDU(this.message);

        }
    }
}
