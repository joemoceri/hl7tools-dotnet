using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSRM_S04
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentARQ arq{get; init;}
public HL7V25SegmentAPR apr{get; init;}
public HL7V25SegmentNTE nte{get; init;}


        public string Id { get { return @"SRM_S04"; } }
        public string MessageStructureId { get { return @"SRM_S04"; } }
        public string EventDescription { get { return @"Schedule request - Appointment cancellation"; } }

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

        public HL7V25TriggerEventSRM_S04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.arq = new HL7V25SegmentARQ(this.message);
this.apr = new HL7V25SegmentAPR(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
