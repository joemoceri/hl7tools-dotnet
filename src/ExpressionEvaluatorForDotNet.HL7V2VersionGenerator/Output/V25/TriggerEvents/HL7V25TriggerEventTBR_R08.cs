using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventTBR_R08
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentMSA msa{ get; init; }
public HL7V25SegmentERR err{ get; init; }
public HL7V25SegmentQAK qak{ get; init; }
public HL7V25SegmentRDF rdf{ get; init; }
public HL7V25SegmentRDT rdt{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


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

        public HL7V25TriggerEventTBR_R08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.rdf = new HL7V25SegmentRDF(this.message);
this.rdt = new HL7V25SegmentRDT(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
