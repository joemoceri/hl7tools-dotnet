using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSIU_S12
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSCH sch{get; init;}
public HL7V28SegmentTQ1 tq1{get; init;}
public HL7V28SegmentNTE nte{get; init;}


        public string Id { get { return @"SIU_S12"; } }
        public string MessageStructureId { get { return @"SIU_S12"; } }
        public string EventDescription { get { return @"Notification of new appointment booking"; } }

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

        public HL7V28TriggerEventSIU_S12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sch = new HL7V28SegmentSCH(this.message);
this.tq1 = new HL7V28SegmentTQ1(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
