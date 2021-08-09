using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventORL_O36
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentMSA msa{get; init;}
public HL7V251SegmentERR err{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentNTE nte{get; init;}


        public string Id { get { return @"ORL_O36"; } }
        public string MessageStructureId { get { return @"ORL_O36"; } }
        public string EventDescription { get { return @"Laboratory Order Response to a Single Container of a Specimen OML"; } }

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

        public HL7V251TriggerEventORL_O36(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
