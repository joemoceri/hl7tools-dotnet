using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventVQQ_Q07
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentVTQ vtq{get; init;}
public HL7V26SegmentRDF rdf{get; init;}
public HL7V26SegmentDSC dsc{get; init;}


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

        public HL7V26TriggerEventVQQ_Q07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.vtq = new HL7V26SegmentVTQ(this.message);
this.rdf = new HL7V26SegmentRDF(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
