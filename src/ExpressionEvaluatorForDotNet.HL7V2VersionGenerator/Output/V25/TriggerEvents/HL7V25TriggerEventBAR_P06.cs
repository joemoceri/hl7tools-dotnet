using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventBAR_P06
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEVN evn{get; init;}


        public string Id { get { return @"BAR_P06"; } }
        public string MessageStructureId { get { return @"BAR_P06"; } }
        public string EventDescription { get { return @"End account"; } }

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

        public HL7V25TriggerEventBAR_P06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);

        }
    }
}
