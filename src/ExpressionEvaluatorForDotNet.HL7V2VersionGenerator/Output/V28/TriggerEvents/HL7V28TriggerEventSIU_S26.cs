using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSIU_S26
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSCH sch;
public readonly HL7V28SegmentTQ1 tq1;
public readonly HL7V28SegmentNTE nte;


        public string Id { get { return @"SIU_S26"; } }
        public string MessageStructureId { get { return @"SIU_S26"; } }
        public string EventDescription { get { return @"SIU/ACK Notification that patient did not show up for schedule appointment"; } }

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

        public HL7V28TriggerEventSIU_S26(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sch = new HL7V28SegmentSCH(this.message);
this.tq1 = new HL7V28SegmentTQ1(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
