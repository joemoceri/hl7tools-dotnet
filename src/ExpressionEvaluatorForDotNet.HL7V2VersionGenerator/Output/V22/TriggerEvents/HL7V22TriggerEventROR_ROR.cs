using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventROR_ROR
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentMSA msa{get; init;}
public HL7V22SegmentERR err{get; init;}
public HL7V22SegmentDSC dsc{get; init;}


        public string Id { get { return @"ROR_ROR"; } }
        public string MessageStructureId { get { return @"ROR_ROR"; } }
        public string EventDescription { get { return @"Pharmacy Prescription Order Response"; } }

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

        public HL7V22TriggerEventROR_ROR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.err = new HL7V22SegmentERR(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
