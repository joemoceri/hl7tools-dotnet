using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRQQ_Q01
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentERQ erq{get; init;}
public HL7V23SegmentDSC dsc{get; init;}


        public string Id { get { return @"RQQ_Q01"; } }
        public string MessageStructureId { get { return @"RQQ_Q01"; } }
        public string EventDescription { get { return @"Event replay query"; } }

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

        public HL7V23TriggerEventRQQ_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.erq = new HL7V23SegmentERQ(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
