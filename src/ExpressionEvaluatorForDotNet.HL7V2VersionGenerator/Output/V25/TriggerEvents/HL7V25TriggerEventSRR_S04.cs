using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSRR_S04
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;


        public string Id { get { return @"SRR_S04"; } }
        public string MessageStructureId { get { return @"SRR_S04"; } }
        public string EventDescription { get { return @"Scheduled request response - Appointment cancellation"; } }

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

        public HL7V25TriggerEventSRR_S04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);

        }
    }
}