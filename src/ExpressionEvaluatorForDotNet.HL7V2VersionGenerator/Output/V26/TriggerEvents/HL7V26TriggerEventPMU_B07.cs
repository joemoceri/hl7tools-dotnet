using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPMU_B07
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentEVN evn{ get; init; }
public HL7V26SegmentSTF stf{ get; init; }
public HL7V26SegmentPRA pra{ get; init; }


        public string Id { get { return @"PMU_B07"; } }
        public string MessageStructureId { get { return @"PMU_B07"; } }
        public string EventDescription { get { return @"Grant Certificate/Permission"; } }

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

        public HL7V26TriggerEventPMU_B07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.stf = new HL7V26SegmentSTF(this.message);
this.pra = new HL7V26SegmentPRA(this.message);

        }
    }
}
