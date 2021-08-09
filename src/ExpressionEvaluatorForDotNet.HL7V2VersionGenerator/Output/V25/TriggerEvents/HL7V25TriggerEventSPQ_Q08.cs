using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSPQ_Q08
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentSPR spr{ get; init; }
public HL7V25SegmentRDF rdf{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


        public string Id { get { return @"SPQ_Q08"; } }
        public string MessageStructureId { get { return @"SPQ_Q08"; } }
        public string EventDescription { get { return @"Stored Procedure Request"; } }

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

        public HL7V25TriggerEventSPQ_Q08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.spr = new HL7V25SegmentSPR(this.message);
this.rdf = new HL7V25SegmentRDF(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
