using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventUDM_R06
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentURD urd{ get; init; }
public HL7V231SegmentURS urs{ get; init; }
public HL7V231SegmentDSP dsp{ get; init; }
public HL7V231SegmentDSC dsc{ get; init; }


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

        public HL7V231TriggerEventUDM_R06(HL7V2Message message)
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
