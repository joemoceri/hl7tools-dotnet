using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventTBR_R08
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMSA msa{ get; init; }
public HL7V231SegmentERR err{ get; init; }
public HL7V231SegmentQAK qak{ get; init; }
public HL7V231SegmentRDF rdf{ get; init; }
public HL7V231SegmentRDT rdt{ get; init; }
public HL7V231SegmentDSC dsc{ get; init; }


        public string Id { get { return @"TBR_R08"; } }
        public string MessageStructureId { get { return @"TBR_R08"; } }
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

        public HL7V231TriggerEventTBR_R08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.qak = new HL7V231SegmentQAK(this.message);
this.rdf = new HL7V231SegmentRDF(this.message);
this.rdt = new HL7V231SegmentRDT(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
