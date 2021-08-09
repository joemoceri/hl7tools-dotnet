using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSRR_S07
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentMSA msa{ get; init; }
public HL7V28SegmentERR err{ get; init; }


        public string Id { get { return @"SRR_S07"; } }
        public string MessageStructureId { get { return @"SRR_S07"; } }
        public string EventDescription { get { return @"Scheduled Request Response - Request Addition of Service/Resource on Appointment "; } }

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

        public HL7V28TriggerEventSRR_S07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);

        }
    }
}
