using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQSX_J02
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentQID qid;


        public string Id { get { return @"QSX_J02"; } }
        public string MessageStructureId { get { return @"QSX_J02"; } }
        public string EventDescription { get { return @"Cancel Subscription"; } }

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

        public HL7V251TriggerEventQSX_J02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qid = new HL7V251SegmentQID(this.message);

        }
    }
}
