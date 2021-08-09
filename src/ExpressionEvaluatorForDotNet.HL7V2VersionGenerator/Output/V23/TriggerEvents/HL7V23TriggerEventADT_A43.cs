using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventADT_A43
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentEVN evn{get; init;}


        public string Id { get { return @"ADT_A43"; } }
        public string MessageStructureId { get { return @"ADT_A43"; } }
        public string EventDescription { get { return @"Move patient information - internal ID"; } }

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

        public HL7V23TriggerEventADT_A43(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.evn = new HL7V23SegmentEVN(this.message);

        }
    }
}
