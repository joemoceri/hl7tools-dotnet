using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSRR_S05
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentMSA msa{ get; init; }
public HL7V25SegmentERR err{ get; init; }


        public string Id { get { return @"SRR_S05"; } }
        public string MessageStructureId { get { return @"SRR_S05"; } }
        public string EventDescription { get { return @"Scheduled request response - Appointment discontinuation"; } }

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

        public HL7V25TriggerEventSRR_S05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);

        }
    }
}
