using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventROR_ROR
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentMSA msa{ get; init; }
public HL7V251SegmentERR err{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"ROR_ROR"; } }
        public string MessageStructureId { get { return @"ROR_ROR"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Order Response"; } }

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

        public HL7V251TriggerEventROR_ROR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
