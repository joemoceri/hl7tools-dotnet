using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventQBP_Z99
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentQPD qpd{ get; init; }
public HL7V27SegmentRDF rdf{ get; init; }
public HL7V27SegmentRCP rcp{ get; init; }
public HL7V27SegmentDSC dsc{ get; init; }


        public string Id { get { return @"QBP_Z99"; } }
        public string MessageStructureId { get { return @"QBP_Z99"; } }
        public string EventDescription { get { return @"Who Am I"; } }

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

        public HL7V27TriggerEventQBP_Z99(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.qpd = new HL7V27SegmentQPD(this.message);
this.rdf = new HL7V27SegmentRDF(this.message);
this.rcp = new HL7V27SegmentRCP(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
