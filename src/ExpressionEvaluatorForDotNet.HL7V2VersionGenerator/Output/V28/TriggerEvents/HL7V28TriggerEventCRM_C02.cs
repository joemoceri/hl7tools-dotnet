using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventCRM_C02
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}


        public string Id { get { return @"CRM_C02"; } }
        public string MessageStructureId { get { return @"CRM_C02"; } }
        public string EventDescription { get { return @"Cancel a patient registration on clinical trial (for clerical mistakes onl"; } }

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

        public HL7V28TriggerEventCRM_C02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);

        }
    }
}
