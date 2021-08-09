using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRRE_O02
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMSA msa{ get; init; }
public HL7V231SegmentERR err{ get; init; }
public HL7V231SegmentNTE nte{ get; init; }


        public string Id { get { return @"RRE_O02"; } }
        public string MessageStructureId { get { return @"RRE_O02"; } }
        public string EventDescription { get { return @"Pharmacy/treatment encoded order acknowledgment message"; } }

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

        public HL7V231TriggerEventRRE_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
