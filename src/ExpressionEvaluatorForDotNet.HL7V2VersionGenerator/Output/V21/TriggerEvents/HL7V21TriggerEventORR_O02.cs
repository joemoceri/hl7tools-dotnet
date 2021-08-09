using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventORR_O02
    {
        public HL7V2Message message { get; init; }
        public HL7V21SegmentMSH msh{ get; init; }
public HL7V21SegmentMSA msa{ get; init; }
public HL7V21SegmentNTE nte{ get; init; }


        public string Id { get { return @"ORR_O02"; } }
        public string MessageStructureId { get { return @"ORR_O02"; } }
        public string EventDescription { get { return @"Respone Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventORR_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.msa = new HL7V21SegmentMSA(this.message);
this.nte = new HL7V21SegmentNTE(this.message);

        }
    }
}
