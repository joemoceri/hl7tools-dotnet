using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventORU_R01
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentDSC dsc{ get; init; }


        public string Id { get { return @"ORU_R01"; } }
        public string MessageStructureId { get { return @"ORU_R01"; } }
        public string EventDescription { get { return @"Unsolicited Transmission Of Requested Information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V22TriggerEventORU_R01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
