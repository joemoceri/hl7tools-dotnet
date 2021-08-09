using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventORU_R03
    {
        private readonly HL7V2Message message;
        public HL7V21SegmentMSH msh{get; init;}


        public string Id { get { return @"ORU_R03"; } }
        public string MessageStructureId { get { return @"ORU_R03"; } }
        public string EventDescription { get { return @"Display oriented results, queyr/unsol. update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventORU_R03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);

        }
    }
}
