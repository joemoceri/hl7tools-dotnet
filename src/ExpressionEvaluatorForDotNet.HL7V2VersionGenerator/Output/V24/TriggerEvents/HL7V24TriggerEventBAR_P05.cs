using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventBAR_P05
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEVN evn{get; init;}
public HL7V24SegmentPID pid{get; init;}
public HL7V24SegmentPD1 pd1{get; init;}
public HL7V24SegmentROL rol{get; init;}


        public string Id { get { return @"BAR_P05"; } }
        public string MessageStructureId { get { return @"BAR_P05"; } }
        public string EventDescription { get { return @"Update account"; } }

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

        public HL7V24TriggerEventBAR_P05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
