using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventUDM_Q05
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentURD urd;
public readonly HL7V27SegmentURS urs;
public readonly HL7V27SegmentDSP dsp;
public readonly HL7V27SegmentDSC dsc;


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
                        "CH_05",
                    };
            }
        }

        public HL7V27TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.urd = new HL7V27SegmentURD(this.message);
this.urs = new HL7V27SegmentURS(this.message);
this.dsp = new HL7V27SegmentDSP(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
