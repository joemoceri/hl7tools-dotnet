using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPMU_B01
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentEVN evn{ get; init; }
public HL7V26SegmentSTF stf{ get; init; }
public HL7V26SegmentPRA pra{ get; init; }
public HL7V26SegmentORG org{ get; init; }
public HL7V26SegmentAFF aff{ get; init; }
public HL7V26SegmentLAN lan{ get; init; }
public HL7V26SegmentEDU edu{ get; init; }
public HL7V26SegmentCER cer{ get; init; }


        public string Id { get { return @"PMU_B01"; } }
        public string MessageStructureId { get { return @"PMU_B01"; } }
        public string EventDescription { get { return @"Add Personnel Record"; } }

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

        public HL7V26TriggerEventPMU_B01(HL7V2Message message)
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
