using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventUDM_R06
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentURD urd;
public readonly HL7V23SegmentURS urs;
public readonly HL7V23SegmentDSP dsp;
public readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"UDM_R06"; } }
        public string MessageStructureId { get { return @"UDM_R06"; } }
        public string EventDescription { get { return @"Continuation of unsolicited display update message"; } }

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

        public HL7V23TriggerEventUDM_R06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.urd = new HL7V23SegmentURD(this.message);
this.urs = new HL7V23SegmentURS(this.message);
this.dsp = new HL7V23SegmentDSP(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
