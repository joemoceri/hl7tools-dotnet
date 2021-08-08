using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventNMQ_N02
    {
        private readonly HL7V2Message message;
        private readonly HL7V22SegmentMSH msh;


        public string Id { get { return @"NMQ_N02"; } }
        public string MessageStructureId { get { return @"NMQ_N02"; } }
        public string EventDescription { get { return @"Network Management Query"; } }

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

        public HL7V22TriggerEventNMQ_N02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);

        }
    }
}
