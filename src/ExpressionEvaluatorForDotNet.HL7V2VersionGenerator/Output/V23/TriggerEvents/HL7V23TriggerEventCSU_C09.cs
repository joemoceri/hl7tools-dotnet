using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventCSU_C09
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }


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

        public HL7V23TriggerEventCSU_C09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);

        }
    }
}
