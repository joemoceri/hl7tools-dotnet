using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventEQQ_Q04
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentEQL eql{ get; init; }
public HL7V231SegmentDSC dsc{ get; init; }


        public string Id { get { return @"EQQ_Q04"; } }
        public string MessageStructureId { get { return @"EQQ_Q04"; } }
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

        public HL7V231TriggerEventEQQ_Q04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.eql = new HL7V231SegmentEQL(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
