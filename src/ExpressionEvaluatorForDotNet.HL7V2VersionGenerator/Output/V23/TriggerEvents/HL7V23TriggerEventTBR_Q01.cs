using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventTBR_Q01
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentMSA msa{get; init;}
public HL7V23SegmentERR err{get; init;}
public HL7V23SegmentQAK qak{get; init;}
public HL7V23SegmentRDF rdf{get; init;}
public HL7V23SegmentRDT rdt{get; init;}
public HL7V23SegmentDSC dsc{get; init;}


        public string Id { get { return @"TBR_Q01"; } }
        public string MessageStructureId { get { return @"TBR_Q01"; } }
        public string EventDescription { get { return @"Tabular data response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V23TriggerEventTBR_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.qak = new HL7V23SegmentQAK(this.message);
this.rdf = new HL7V23SegmentRDF(this.message);
this.rdt = new HL7V23SegmentRDT(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
