using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventBAR_P02
    {
        public readonly HL7V2Message message;
        public readonly HL7V21SegmentMSH msh;
public readonly HL7V21SegmentEVN evn;


        public string Id { get { return @"BAR_P02"; } }
        public string MessageStructureId { get { return @"BAR_P02"; } }
        public string EventDescription { get { return @"Purge Patient Accounts"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventBAR_P02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.evn = new HL7V21SegmentEVN(this.message);

        }
    }
}
