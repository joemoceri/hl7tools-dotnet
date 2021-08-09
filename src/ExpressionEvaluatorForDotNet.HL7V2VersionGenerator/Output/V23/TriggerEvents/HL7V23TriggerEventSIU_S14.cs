using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventSIU_S14
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentSCH sch{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }


        public string Id { get { return @"SIU_S14"; } }
        public string MessageStructureId { get { return @"SIU_S14"; } }
        public string EventDescription { get { return @"Notification of appointment modification"; } }

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

        public HL7V23TriggerEventSIU_S14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.sch = new HL7V23SegmentSCH(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
