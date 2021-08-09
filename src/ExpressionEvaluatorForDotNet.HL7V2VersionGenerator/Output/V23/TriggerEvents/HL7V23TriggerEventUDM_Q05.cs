using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentURD urd{get; init;}
public HL7V23SegmentURS urs{get; init;}
public HL7V23SegmentDSP dsp{get; init;}
public HL7V23SegmentDSC dsc{get; init;}


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

        public HL7V23TriggerEventUDM_Q05(HL7V2Message message)
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
