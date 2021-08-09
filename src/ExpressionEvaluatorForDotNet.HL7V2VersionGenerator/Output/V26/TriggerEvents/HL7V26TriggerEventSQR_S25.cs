using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSQR_S25
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentMSA msa{get; init;}
public HL7V26SegmentERR err{get; init;}
public HL7V26SegmentQAK qak{get; init;}
public HL7V26SegmentDSC dsc{get; init;}


        public string Id { get { return @"SQR_S25"; } }
        public string MessageStructureId { get { return @"SQR_S25"; } }
        public string EventDescription { get { return @"Schedule Response"; } }

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

        public HL7V26TriggerEventSQR_S25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
