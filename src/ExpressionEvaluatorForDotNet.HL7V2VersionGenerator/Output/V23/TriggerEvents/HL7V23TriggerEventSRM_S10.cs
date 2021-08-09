using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventSRM_S10
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentARQ arq{ get; init; }
public HL7V23SegmentAPR apr{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }


        public string Id { get { return @"SRM_S10"; } }
        public string MessageStructureId { get { return @"SRM_S10"; } }
        public string EventDescription { get { return @"Request discontinuation of service/resource on appointment"; } }

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

        public HL7V23TriggerEventSRM_S10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.arq = new HL7V23SegmentARQ(this.message);
this.apr = new HL7V23SegmentAPR(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
