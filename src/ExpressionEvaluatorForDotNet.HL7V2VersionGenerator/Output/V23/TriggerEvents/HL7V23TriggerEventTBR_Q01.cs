using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventTBR_Q01
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentERR err;
public readonly HL7V23SegmentQAK qak;
public readonly HL7V23SegmentRDF rdf;
public readonly HL7V23SegmentRDT rdt;
public readonly HL7V23SegmentDSC dsc;


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
