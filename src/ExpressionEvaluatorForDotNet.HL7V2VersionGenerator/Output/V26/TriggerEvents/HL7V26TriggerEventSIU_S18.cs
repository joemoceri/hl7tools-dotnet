using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSIU_S18
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSCH sch;
public readonly HL7V26SegmentTQ1 tq1;
public readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"SIU_S18"; } }
        public string MessageStructureId { get { return @"SIU_S18"; } }
        public string EventDescription { get { return @"Notification of Addition of Service/Resource on Appointment"; } }

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

        public HL7V26TriggerEventSIU_S18(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sch = new HL7V26SegmentSCH(this.message);
this.tq1 = new HL7V26SegmentTQ1(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
