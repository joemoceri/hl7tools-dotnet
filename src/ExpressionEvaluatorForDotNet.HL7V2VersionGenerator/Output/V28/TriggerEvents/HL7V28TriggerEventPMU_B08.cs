using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventPMU_B08
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentEVN evn{ get; init; }
public HL7V28SegmentSTF stf{ get; init; }
public HL7V28SegmentPRA pra{ get; init; }
public HL7V28SegmentCER cer{ get; init; }


        public string Id { get { return @"PMU_B08"; } }
        public string MessageStructureId { get { return @"PMU_B08"; } }
        public string EventDescription { get { return @"Revoke Certificate/Permission"; } }

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

        public HL7V28TriggerEventPMU_B08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.stf = new HL7V28SegmentSTF(this.message);
this.pra = new HL7V28SegmentPRA(this.message);
this.cer = new HL7V28SegmentCER(this.message);

        }
    }
}
