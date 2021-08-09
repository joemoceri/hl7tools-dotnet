using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventMCF
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentMFA mfa{ get; init; }
public HL7V22SegmentERR err{ get; init; }


        public string Id { get { return @"MCF"; } }
        public string MessageStructureId { get { return @"MCF"; } }
        public string EventDescription { get { return @"Delayed acknowledgement "; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V22TriggerEventMCF(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.mfa = new HL7V22SegmentMFA(this.message);
this.err = new HL7V22SegmentERR(this.message);

        }
    }
}
