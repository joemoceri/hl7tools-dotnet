using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventNMD_N01
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}


        public string Id { get { return @"NMD_N01"; } }
        public string MessageStructureId { get { return @"NMD_N01"; } }
        public string EventDescription { get { return @"Network Management Data"; } }

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

        public HL7V22TriggerEventNMD_N01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);

        }
    }
}
