using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A39
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentEVN evn{ get; init; }


        public string Id { get { return @"ADT_A39"; } }
        public string MessageStructureId { get { return @"ADT_A39"; } }
        public string EventDescription { get { return @"Merge person - patient id"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V231TriggerEventADT_A39(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);

        }
    }
}
