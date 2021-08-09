using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventROR_ROR
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentMSA msa{get; init;}
public HL7V231SegmentERR err{get; init;}
public HL7V231SegmentDSC dsc{get; init;}


        public string Id { get { return @"ROR_ROR"; } }
        public string MessageStructureId { get { return @"ROR_ROR"; } }
        public string EventDescription { get { return @"pharmacy/treatment order response"; } }

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

        public HL7V231TriggerEventROR_ROR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
