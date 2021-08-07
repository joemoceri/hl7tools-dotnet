using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventVQQ_Q07
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentVTQ vtq;
public readonly HL7V231SegmentRDF rdf;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"VQQ_Q07"; } }
        public string MessageStructureId { get { return @"VQQ_Q07"; } }
        public string EventDescription { get { return @"Virtual table query"; } }

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

        public HL7V231TriggerEventVQQ_Q07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.vtq = new HL7V231SegmentVTQ(this.message);
this.rdf = new HL7V231SegmentRDF(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
