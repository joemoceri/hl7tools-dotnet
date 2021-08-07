using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSRR_S08
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentMSA msa;
public readonly HL7V271SegmentERR err;


        public string Id { get { return @"SRR_S08"; } }
        public string MessageStructureId { get { return @"SRR_S08"; } }
        public string EventDescription { get { return @"Scheduled Request Response - Request Modification of Service/Resource on Appointment "; } }

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

        public HL7V271TriggerEventSRR_S08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);

        }
    }
}
