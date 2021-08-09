using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventNMD_N02
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }


        public string Id { get { return @"NMD_N02"; } }
        public string MessageStructureId { get { return @"NMD_N02"; } }
        public string EventDescription { get { return @"Network management data message"; } }

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

        public HL7V231TriggerEventNMD_N02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);

        }
    }
}
