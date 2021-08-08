using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventEQQ_Q01
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentEQL eql;
private readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"EQQ_Q01"; } }
        public string MessageStructureId { get { return @"EQQ_Q01"; } }
        public string EventDescription { get { return @"Embedded query language query"; } }

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

        public HL7V23TriggerEventEQQ_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.eql = new HL7V23SegmentEQL(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
