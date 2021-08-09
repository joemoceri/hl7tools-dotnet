using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventEQQ_Q04
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentEQL eql{ get; init; }
public HL7V24SegmentDSC dsc{ get; init; }


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
                        "CH_05",

                    };
            }
        }

        public HL7V24TriggerEventEQQ_Q04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.eql = new HL7V24SegmentEQL(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
