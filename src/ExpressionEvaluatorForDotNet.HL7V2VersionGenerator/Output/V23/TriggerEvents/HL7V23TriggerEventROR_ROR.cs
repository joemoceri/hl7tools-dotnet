using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventROR_ROR
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentMSA msa{ get; init; }
public HL7V23SegmentERR err{ get; init; }
public HL7V23SegmentDSC dsc{ get; init; }


        public string Id { get { return @"ROR_ROR"; } }
        public string MessageStructureId { get { return @"ROR_ROR"; } }
        public string EventDescription { get { return @"Pharmacy/treatment order response"; } }

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

        public HL7V23TriggerEventROR_ROR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
