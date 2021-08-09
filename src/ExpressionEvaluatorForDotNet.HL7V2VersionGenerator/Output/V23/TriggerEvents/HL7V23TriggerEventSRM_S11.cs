using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventSRM_S11
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentARQ arq{get; init;}
public HL7V23SegmentAPR apr{get; init;}
public HL7V23SegmentNTE nte{get; init;}


        public string Id { get { return @"SRM_S11"; } }
        public string MessageStructureId { get { return @"SRM_S11"; } }
        public string EventDescription { get { return @"Request deletion of service/resource on appointment"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

                    };
            }
        }

        public HL7V23TriggerEventSRM_S11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.arq = new HL7V23SegmentARQ(this.message);
this.apr = new HL7V23SegmentAPR(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
