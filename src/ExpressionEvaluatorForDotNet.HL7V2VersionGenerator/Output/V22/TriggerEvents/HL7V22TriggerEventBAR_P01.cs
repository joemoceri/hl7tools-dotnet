using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventBAR_P01
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentEVN evn{get; init;}
public HL7V22SegmentPID pid{get; init;}


        public string Id { get { return @"BAR_P01"; } }
        public string MessageStructureId { get { return @"BAR_P01"; } }
        public string EventDescription { get { return @"Add and Update Patient Accounts"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V22TriggerEventBAR_P01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);

        }
    }
}
