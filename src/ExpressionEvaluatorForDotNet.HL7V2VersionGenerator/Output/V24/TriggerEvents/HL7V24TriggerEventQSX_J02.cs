using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQSX_J02
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentQID qid{ get; init; }


        public string Id { get { return @"QSX_J02"; } }
        public string MessageStructureId { get { return @"QSX_J02"; } }
        public string EventDescription { get { return @"Cancel subscription/acknowledge message"; } }

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

        public HL7V24TriggerEventQSX_J02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qid = new HL7V24SegmentQID(this.message);

        }
    }
}
