using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventBAR_P02
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentEVN evn{get; init;}


        public string Id { get { return @"BAR_P02"; } }
        public string MessageStructureId { get { return @"BAR_P02"; } }
        public string EventDescription { get { return @"Purge patient accounts"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V231TriggerEventBAR_P02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);

        }
    }
}
