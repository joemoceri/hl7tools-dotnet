using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSIU_S21
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentSCH sch{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }


        public string Id { get { return @"SIU_S21"; } }
        public string MessageStructureId { get { return @"SIU_S21"; } }
        public string EventDescription { get { return @"Notification of Discontinuation of Service/Resource on Appointment"; } }

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

        public HL7V24TriggerEventSIU_S21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.sch = new HL7V24SegmentSCH(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
