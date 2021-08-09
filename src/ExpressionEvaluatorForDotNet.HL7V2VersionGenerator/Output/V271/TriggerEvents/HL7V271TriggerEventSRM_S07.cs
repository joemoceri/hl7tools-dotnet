using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSRM_S07
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentARQ arq{get; init;}
public HL7V271SegmentAPR apr{get; init;}
public HL7V271SegmentNTE nte{get; init;}


        public string Id { get { return @"SRM_S07"; } }
        public string MessageStructureId { get { return @"SRM_S07"; } }
        public string EventDescription { get { return @"Request addition of service/resource on appointment"; } }

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

        public HL7V271TriggerEventSRM_S07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.arq = new HL7V271SegmentARQ(this.message);
this.apr = new HL7V271SegmentAPR(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
