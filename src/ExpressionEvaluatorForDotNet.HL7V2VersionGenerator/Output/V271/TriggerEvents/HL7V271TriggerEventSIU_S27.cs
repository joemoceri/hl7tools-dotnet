using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSIU_S27
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSCH sch;
private readonly HL7V271SegmentTQ1 tq1;
private readonly HL7V271SegmentNTE nte;


        public string Id { get { return @"SIU_S27"; } }
        public string MessageStructureId { get { return @"SIU_S27"; } }
        public string EventDescription { get { return @"Broadcast Notification of Scheduled Appointments"; } }

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

        public HL7V271TriggerEventSIU_S27(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sch = new HL7V271SegmentSCH(this.message);
this.tq1 = new HL7V271SegmentTQ1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
