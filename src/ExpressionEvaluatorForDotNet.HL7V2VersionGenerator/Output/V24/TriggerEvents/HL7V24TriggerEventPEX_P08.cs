using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPEX_P08
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEVN evn;
private readonly HL7V24SegmentPID pid;
private readonly HL7V24SegmentPD1 pd1;
private readonly HL7V24SegmentNTE nte;


        public string Id { get { return @"PEX_P08"; } }
        public string MessageStructureId { get { return @"PEX_P08"; } }
        public string EventDescription { get { return @"Unsolicited update individual product experience report"; } }

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

        public HL7V24TriggerEventPEX_P08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.pd1 = new HL7V24SegmentPD1(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
