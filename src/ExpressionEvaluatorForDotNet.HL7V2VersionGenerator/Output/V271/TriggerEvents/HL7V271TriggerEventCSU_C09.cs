using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventCSU_C09
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}


        public string Id { get { return @"CSU_C09"; } }
        public string MessageStructureId { get { return @"CSU_C09"; } }
        public string EventDescription { get { return @"Automated time intervals for reporting, like monthly"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V271TriggerEventCSU_C09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);

        }
    }
}
