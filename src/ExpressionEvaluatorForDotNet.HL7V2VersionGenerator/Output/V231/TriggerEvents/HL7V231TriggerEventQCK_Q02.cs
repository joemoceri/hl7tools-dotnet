using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventQCK_Q02
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentMSA msa{get; init;}
public HL7V231SegmentERR err{get; init;}
public HL7V231SegmentQAK qak{get; init;}


        public string Id { get { return @"QCK_Q02"; } }
        public string MessageStructureId { get { return @"QCK_Q02"; } }
        public string EventDescription { get { return @"Deferred query"; } }

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

        public HL7V231TriggerEventQCK_Q02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.qak = new HL7V231SegmentQAK(this.message);

        }
    }
}
