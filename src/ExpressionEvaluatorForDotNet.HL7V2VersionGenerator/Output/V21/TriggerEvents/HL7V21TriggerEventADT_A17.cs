using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventADT_A17
    {
        public readonly HL7V2Message message;
        public readonly HL7V21SegmentMSH msh;
public readonly HL7V21SegmentEVN evn;


        public string Id { get { return @"ADT_A17"; } }
        public string MessageStructureId { get { return @"ADT_A17"; } }
        public string EventDescription { get { return @"Swap Patients"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventADT_A17(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.evn = new HL7V21SegmentEVN(this.message);

        }
    }
}
