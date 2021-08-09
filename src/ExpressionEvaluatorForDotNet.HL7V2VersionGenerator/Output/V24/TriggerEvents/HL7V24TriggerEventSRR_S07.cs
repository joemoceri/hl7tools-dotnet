using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSRR_S07
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMSA msa{get; init;}
public HL7V24SegmentERR err{get; init;}


        public string Id { get { return @"SRR_S07"; } }
        public string MessageStructureId { get { return @"SRR_S07"; } }
        public string EventDescription { get { return @"Scheduled request response - Addition of service/resource on appointment"; } }

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

        public HL7V24TriggerEventSRR_S07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);

        }
    }
}
