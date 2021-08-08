using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventCRM_C04
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;


        public string Id { get { return @"CRM_C04"; } }
        public string MessageStructureId { get { return @"CRM_C04"; } }
        public string EventDescription { get { return @"Patient has gone off a clinical trial"; } }

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

        public HL7V231TriggerEventCRM_C04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);

        }
    }
}
