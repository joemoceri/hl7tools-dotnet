using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSRM_S04
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentARQ arq;
public readonly HL7V26SegmentAPR apr;
public readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"SRM_S04"; } }
        public string MessageStructureId { get { return @"SRM_S04"; } }
        public string EventDescription { get { return @"Request Appointment Cancellation"; } }

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

        public HL7V26TriggerEventSRM_S04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.arq = new HL7V26SegmentARQ(this.message);
this.apr = new HL7V26SegmentAPR(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
