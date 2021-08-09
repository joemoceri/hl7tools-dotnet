using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventTBR_R08
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentMSA msa{ get; init; }
public HL7V24SegmentERR err{ get; init; }
public HL7V24SegmentQAK qak{ get; init; }
public HL7V24SegmentRDF rdf{ get; init; }
public HL7V24SegmentRDT rdt{ get; init; }
public HL7V24SegmentDSC dsc{ get; init; }


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
                        "CH_05",

                    };
            }
        }

        public HL7V24TriggerEventTBR_R08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.rdf = new HL7V24SegmentRDF(this.message);
this.rdt = new HL7V24SegmentRDT(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
