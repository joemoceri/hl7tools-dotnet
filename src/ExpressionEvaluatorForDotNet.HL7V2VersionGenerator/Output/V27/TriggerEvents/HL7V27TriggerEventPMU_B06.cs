using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventPMU_B06
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentEVN evn{get; init;}
public HL7V27SegmentSTF stf{get; init;}
public HL7V27SegmentPRA pra{get; init;}
public HL7V27SegmentORG org{get; init;}


        public string Id { get { return @"PMU_B06"; } }
        public string MessageStructureId { get { return @"PMU_B06"; } }
        public string EventDescription { get { return @"Terminate practicing person"; } }

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

        public HL7V27TriggerEventPMU_B06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.stf = new HL7V27SegmentSTF(this.message);
this.pra = new HL7V27SegmentPRA(this.message);
this.org = new HL7V27SegmentORG(this.message);

        }
    }
}
