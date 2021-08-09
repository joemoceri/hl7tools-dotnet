using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQBP_Q13
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentQPD qpd{get; init;}
public HL7V251SegmentRDF rdf{get; init;}
public HL7V251SegmentRCP rcp{get; init;}
public HL7V251SegmentDSC dsc{get; init;}


        public string Id { get { return @"QBP_Q13"; } }
        public string MessageStructureId { get { return @"QBP_Q13"; } }
        public string EventDescription { get { return @"Query by Parameter Requesting an RTB Tabular Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V251TriggerEventQBP_Q13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qpd = new HL7V251SegmentQPD(this.message);
this.rdf = new HL7V251SegmentRDF(this.message);
this.rcp = new HL7V251SegmentRCP(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
