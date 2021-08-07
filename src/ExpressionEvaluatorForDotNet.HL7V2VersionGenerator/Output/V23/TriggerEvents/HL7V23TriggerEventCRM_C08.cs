using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventCRM_C08
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;


        public string Id { get { return @"CRM_C08"; } }
        public string MessageStructureId { get { return @"CRM_C08"; } }
        public string EventDescription { get { return @"Patient has gone off phase of clinical trial"; } }

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

        public HL7V23TriggerEventCRM_C08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);

        }
    }
}
