using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRRO_O02
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentMSA msa;
private readonly HL7V231SegmentERR err;
private readonly HL7V231SegmentNTE nte;


        public string Id { get { return @"RRO_O02"; } }
        public string MessageStructureId { get { return @"RRO_O02"; } }
        public string EventDescription { get { return @"Pharmacy/treatment Order acknowledgment message"; } }

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

        public HL7V231TriggerEventRRO_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
