using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPMU_B02
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentEVN evn;
private readonly HL7V26SegmentSTF stf;
private readonly HL7V26SegmentPRA pra;
private readonly HL7V26SegmentORG org;
private readonly HL7V26SegmentAFF aff;
private readonly HL7V26SegmentLAN lan;
private readonly HL7V26SegmentEDU edu;
private readonly HL7V26SegmentCER cer;


        public string Id { get { return @"PMU_B02"; } }
        public string MessageStructureId { get { return @"PMU_B02"; } }
        public string EventDescription { get { return @"Update Personnel Record"; } }

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

        public HL7V26TriggerEventPMU_B02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.stf = new HL7V26SegmentSTF(this.message);
this.pra = new HL7V26SegmentPRA(this.message);
this.org = new HL7V26SegmentORG(this.message);
this.aff = new HL7V26SegmentAFF(this.message);
this.lan = new HL7V26SegmentLAN(this.message);
this.edu = new HL7V26SegmentEDU(this.message);
this.cer = new HL7V26SegmentCER(this.message);

        }
    }
}
