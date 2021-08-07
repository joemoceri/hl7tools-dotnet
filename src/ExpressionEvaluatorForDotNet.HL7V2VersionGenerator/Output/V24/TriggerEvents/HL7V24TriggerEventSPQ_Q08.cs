using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSPQ_Q08
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentSPR spr;
public readonly HL7V24SegmentRDF rdf;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"SPQ_Q08"; } }
        public string MessageStructureId { get { return @"SPQ_Q08"; } }
        public string EventDescription { get { return @"Stored procedure request"; } }

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

        public HL7V24TriggerEventSPQ_Q08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.spr = new HL7V24SegmentSPR(this.message);
this.rdf = new HL7V24SegmentRDF(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
