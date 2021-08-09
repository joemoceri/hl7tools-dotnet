using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSRM_S09
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentARQ arq{ get; init; }
public HL7V26SegmentAPR apr{ get; init; }
public HL7V26SegmentNTE nte{ get; init; }


        public string Id { get { return @"SRM_S09"; } }
        public string MessageStructureId { get { return @"SRM_S09"; } }
        public string EventDescription { get { return @"Request Cancellation of Service/Resource on Appointment "; } }

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

        public HL7V26TriggerEventSRM_S09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.arq = new HL7V26SegmentARQ(this.message);
this.apr = new HL7V26SegmentAPR(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
