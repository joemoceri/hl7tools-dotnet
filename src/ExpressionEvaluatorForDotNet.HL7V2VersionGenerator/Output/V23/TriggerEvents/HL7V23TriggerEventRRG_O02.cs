using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRRG_O02
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentERR err;
public readonly HL7V23SegmentNTE nte;


        public string Id { get { return @"RRG_O02"; } }
        public string MessageStructureId { get { return @"RRG_O02"; } }
        public string EventDescription { get { return @"Pharmacy/treatment give acknowledgment message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            }
        }

        public HL7V23TriggerEventRRG_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
