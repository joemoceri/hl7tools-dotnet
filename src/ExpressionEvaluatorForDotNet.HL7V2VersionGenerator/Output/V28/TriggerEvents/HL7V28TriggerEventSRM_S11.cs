using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSRM_S11
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentARQ arq{get; init;}
public HL7V28SegmentAPR apr{get; init;}
public HL7V28SegmentNTE nte{get; init;}


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

        public HL7V28TriggerEventSRM_S11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.arq = new HL7V28SegmentARQ(this.message);
this.apr = new HL7V28SegmentAPR(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
