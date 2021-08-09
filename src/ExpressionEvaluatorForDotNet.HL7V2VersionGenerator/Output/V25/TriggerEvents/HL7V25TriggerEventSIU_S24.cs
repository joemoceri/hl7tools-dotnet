using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSIU_S24
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSCH sch{get; init;}
public HL7V25SegmentTQ1 tq1{get; init;}
public HL7V25SegmentNTE nte{get; init;}


        public string Id { get { return @"SIU_S24"; } }
        public string MessageStructureId { get { return @"SIU_S24"; } }
        public string EventDescription { get { return @"Notification of Opened (un-blocked) Schedule Time Slot(s)"; } }

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

        public HL7V25TriggerEventSIU_S24(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sch = new HL7V25SegmentSCH(this.message);
this.tq1 = new HL7V25SegmentTQ1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
