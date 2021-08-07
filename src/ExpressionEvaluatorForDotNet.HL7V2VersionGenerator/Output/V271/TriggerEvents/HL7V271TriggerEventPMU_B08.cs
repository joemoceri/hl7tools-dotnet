using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventPMU_B08
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentEVN evn;
public readonly HL7V271SegmentSTF stf;
public readonly HL7V271SegmentPRA pra;
public readonly HL7V271SegmentCER cer;


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

        public HL7V271TriggerEventPMU_B08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.stf = new HL7V271SegmentSTF(this.message);
this.pra = new HL7V271SegmentPRA(this.message);
this.cer = new HL7V271SegmentCER(this.message);

        }
    }
}
