using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventSIU_S26
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentSCH sch;
public readonly HL7V231SegmentNTE nte;


        public string Id { get { return @"SIU_S26"; } }
        public string MessageStructureId { get { return @"SIU_S26"; } }
        public string EventDescription { get { return @"Notification that patient did not show up for scheduled appointment"; } }

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

        public HL7V231TriggerEventSIU_S26(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.sch = new HL7V231SegmentSCH(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
