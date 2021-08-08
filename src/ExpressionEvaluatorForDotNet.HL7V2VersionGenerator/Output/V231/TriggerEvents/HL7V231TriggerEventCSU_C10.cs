using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventCSU_C10
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;


        public string Id { get { return @"CSU_C10"; } }
        public string MessageStructureId { get { return @"CSU_C10"; } }
        public string EventDescription { get { return @"Patient completes the clinical trial"; } }

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

        public HL7V231TriggerEventCSU_C10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);

        }
    }
}
