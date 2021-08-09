using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventNMD_N02
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}


        public string Id { get { return @"NMD_N02"; } }
        public string MessageStructureId { get { return @"NMD_N02"; } }
        public string EventDescription { get { return @"Application management data message"; } }

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

        public HL7V24TriggerEventNMD_N02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);

        }
    }
}
