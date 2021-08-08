using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQBP_Q13
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentQPD qpd;
private readonly HL7V24SegmentRDF rdf;
private readonly HL7V24SegmentRCP rcp;
private readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"QBP_Q13"; } }
        public string MessageStructureId { get { return @"QBP_Q13"; } }
        public string EventDescription { get { return @"Query by parameter/tabular response "; } }

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

        public HL7V24TriggerEventQBP_Q13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qpd = new HL7V24SegmentQPD(this.message);
this.rdf = new HL7V24SegmentRDF(this.message);
this.rcp = new HL7V24SegmentRCP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
