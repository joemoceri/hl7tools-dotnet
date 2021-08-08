using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQCN_J01
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentQID qid;


        public string Id { get { return @"QCN_J01"; } }
        public string MessageStructureId { get { return @"QCN_J01"; } }
        public string EventDescription { get { return @"Cancel query/acknowledge message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V24TriggerEventQCN_J01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qid = new HL7V24SegmentQID(this.message);

        }
    }
}
