using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventCSU_C11
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;


        public string Id { get { return @"CSU_C11"; } }
        public string MessageStructureId { get { return @"CSU_C11"; } }
        public string EventDescription { get { return @"Patient completes a phase of the clinical trial"; } }

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

        public HL7V24TriggerEventCSU_C11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);

        }
    }
}
