using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventORU_R01
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"ORU_R01"; } }
        public string MessageStructureId { get { return @"ORU_R01"; } }
        public string EventDescription { get { return @"Unsolicited transmission of an observation message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
                    };
            }
        }

        public HL7V23TriggerEventORU_R01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
