using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPMU_B02
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentEVN evn;
public readonly HL7V26SegmentSTF stf;
public readonly HL7V26SegmentPRA pra;
public readonly HL7V26SegmentORG org;
public readonly HL7V26SegmentAFF aff;
public readonly HL7V26SegmentLAN lan;
public readonly HL7V26SegmentEDU edu;
public readonly HL7V26SegmentCER cer;


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
