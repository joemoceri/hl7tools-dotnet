using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventEQQ_Q04
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEQL eql{get; init;}
public HL7V25SegmentDSC dsc{get; init;}


        public string Id { get { return @"EQQ_Q04"; } }
        public string MessageStructureId { get { return @"EQQ_Q04"; } }
        public string EventDescription { get { return @"Embedded Query Language Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V25TriggerEventEQQ_Q04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.eql = new HL7V25SegmentEQL(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
