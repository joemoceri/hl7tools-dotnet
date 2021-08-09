using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentURD urd{get; init;}
public HL7V22SegmentURS urs{get; init;}
public HL7V22SegmentDSP dsp{get; init;}
public HL7V22SegmentDSC dsc{get; init;}


        public string Id { get { return @"UDM_Q05"; } }
        public string MessageStructureId { get { return @"UDM_Q05"; } }
        public string EventDescription { get { return @"Unsolicited Display Update Message"; } }

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

        public HL7V22TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.urd = new HL7V22SegmentURD(this.message);
this.urs = new HL7V22SegmentURS(this.message);
this.dsp = new HL7V22SegmentDSP(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
