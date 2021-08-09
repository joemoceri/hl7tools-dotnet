using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventVQQ_Q07
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentVTQ vtq{ get; init; }
public HL7V251SegmentRDF rdf{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"VQQ_Q07"; } }
        public string MessageStructureId { get { return @"VQQ_Q07"; } }
        public string EventDescription { get { return @"Virtual Table Query"; } }

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

        public HL7V251TriggerEventVQQ_Q07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.vtq = new HL7V251SegmentVTQ(this.message);
this.rdf = new HL7V251SegmentRDF(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
