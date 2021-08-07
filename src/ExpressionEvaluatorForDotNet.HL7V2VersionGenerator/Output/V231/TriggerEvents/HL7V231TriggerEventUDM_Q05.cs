using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventUDM_Q05
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentURD urd;
public readonly HL7V231SegmentURS urs;
public readonly HL7V231SegmentDSP dsp;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"UDM_Q05"; } }
        public string MessageStructureId { get { return @"UDM_Q05"; } }
        public string EventDescription { get { return @"Unsolicited display update message"; } }

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

        public HL7V231TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.urd = new HL7V231SegmentURD(this.message);
this.urs = new HL7V231SegmentURS(this.message);
this.dsp = new HL7V231SegmentDSP(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
