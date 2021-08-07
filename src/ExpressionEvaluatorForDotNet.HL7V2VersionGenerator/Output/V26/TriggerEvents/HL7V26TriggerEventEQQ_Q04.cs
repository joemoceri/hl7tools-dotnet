using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventEQQ_Q04
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentEQL eql;
public readonly HL7V26SegmentDSC dsc;


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

        public HL7V26TriggerEventEQQ_Q04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.eql = new HL7V26SegmentEQL(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
