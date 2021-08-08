using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        private readonly HL7V21SegmentMSH msh;
private readonly HL7V21SegmentURD urd;
private readonly HL7V21SegmentURS urs;
private readonly HL7V21SegmentDSP dsp;
private readonly HL7V21SegmentDSC dsc;


        public string Id { get { return @"UDM_Q05"; } }
        public string MessageStructureId { get { return @"UDM_Q05"; } }
        public string EventDescription { get { return @"Unsolicited Updates, ODM Message, Trigger Event Q05"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.urd = new HL7V21SegmentURD(this.message);
this.urs = new HL7V21SegmentURS(this.message);
this.dsp = new HL7V21SegmentDSP(this.message);
this.dsc = new HL7V21SegmentDSC(this.message);

        }
    }
}
