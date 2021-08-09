using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventSRR_S02
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMSA msa{ get; init; }
public HL7V231SegmentERR err{ get; init; }


        public string Id { get { return @"SRR_S02"; } }
        public string MessageStructureId { get { return @"SRR_S02"; } }
        public string EventDescription { get { return @"Result appointment rescheduling"; } }

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

        public HL7V231TriggerEventSRR_S02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);

        }
    }
}
