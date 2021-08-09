using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSIU_S15
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSCH sch{get; init;}
public HL7V26SegmentTQ1 tq1{get; init;}
public HL7V26SegmentNTE nte{get; init;}


        public string Id { get { return @"SIU_S15"; } }
        public string MessageStructureId { get { return @"SIU_S15"; } }
        public string EventDescription { get { return @"Notification of Appointment Cancellation"; } }

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

        public HL7V26TriggerEventSIU_S15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sch = new HL7V26SegmentSCH(this.message);
this.tq1 = new HL7V26SegmentTQ1(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
