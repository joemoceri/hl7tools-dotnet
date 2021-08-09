using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventSIU_S23
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSCH sch{ get; init; }
public HL7V251SegmentTQ1 tq1{ get; init; }
public HL7V251SegmentNTE nte{ get; init; }


        public string Id { get { return @"SIU_S23"; } }
        public string MessageStructureId { get { return @"SIU_S23"; } }
        public string EventDescription { get { return @"Notification of Blocked Schedule Time Slot(S)"; } }

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

        public HL7V251TriggerEventSIU_S23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sch = new HL7V251SegmentSCH(this.message);
this.tq1 = new HL7V251SegmentTQ1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
