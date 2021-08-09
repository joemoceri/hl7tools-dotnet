using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventCRM_C06
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }


        public string Id { get { return @"CRM_C06"; } }
        public string MessageStructureId { get { return @"CRM_C06"; } }
        public string EventDescription { get { return @"Cancel patient entering a phase"; } }

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

        public HL7V23TriggerEventCRM_C06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);

        }
    }
}
