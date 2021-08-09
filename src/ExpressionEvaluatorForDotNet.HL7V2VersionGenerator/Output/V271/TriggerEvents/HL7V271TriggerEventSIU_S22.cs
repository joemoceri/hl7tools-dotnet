using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSIU_S22
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSCH sch{ get; init; }
public HL7V271SegmentTQ1 tq1{ get; init; }
public HL7V271SegmentNTE nte{ get; init; }


        public string Id { get { return @"SIU_S22"; } }
        public string MessageStructureId { get { return @"SIU_S22"; } }
        public string EventDescription { get { return @"Notification of deletion of service/resource on appointment"; } }

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

        public HL7V271TriggerEventSIU_S22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sch = new HL7V271SegmentSCH(this.message);
this.tq1 = new HL7V271SegmentTQ1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
