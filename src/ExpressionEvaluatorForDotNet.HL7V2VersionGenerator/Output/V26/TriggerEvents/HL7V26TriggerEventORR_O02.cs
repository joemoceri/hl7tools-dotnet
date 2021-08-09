using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventORR_O02
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentMSA msa{get; init;}
public HL7V26SegmentERR err{get; init;}
public HL7V26SegmentNTE nte{get; init;}


        public string Id { get { return @"ORR_O02"; } }
        public string MessageStructureId { get { return @"ORR_O02"; } }
        public string EventDescription { get { return @"General Order Response Message to any ORM"; } }

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

        public HL7V26TriggerEventORR_O02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
