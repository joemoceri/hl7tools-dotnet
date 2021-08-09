using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventNMQ_N01
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}


        public string Id { get { return @"NMQ_N01"; } }
        public string MessageStructureId { get { return @"NMQ_N01"; } }
        public string EventDescription { get { return @"Application management query message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

                    };
            }
        }

        public HL7V24TriggerEventNMQ_N01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);

        }
    }
}
