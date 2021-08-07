using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventRRA_O02
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentMSA msa;
public readonly HL7V22SegmentERR err;
public readonly HL7V22SegmentNTE nte;


        public string Id { get { return @"RRA_O02"; } }
        public string MessageStructureId { get { return @"RRA_O02"; } }
        public string EventDescription { get { return @"Pharmacy/treatment administration acknowledgment message"; } }

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

        public HL7V22TriggerEventRRA_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.err = new HL7V22SegmentERR(this.message);
this.nte = new HL7V22SegmentNTE(this.message);

        }
    }
}
