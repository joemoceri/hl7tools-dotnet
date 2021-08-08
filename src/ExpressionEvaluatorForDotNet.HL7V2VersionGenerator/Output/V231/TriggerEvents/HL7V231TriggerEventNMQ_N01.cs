using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventNMQ_N01
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;


        public string Id { get { return @"NMQ_N01"; } }
        public string MessageStructureId { get { return @"NMQ_N01"; } }
        public string EventDescription { get { return @"Network management query message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V231TriggerEventNMQ_N01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);

        }
    }
}
