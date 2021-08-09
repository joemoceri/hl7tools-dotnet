using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventSIU_S26
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentSCH sch{ get; init; }
public HL7V231SegmentNTE nte{ get; init; }


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
