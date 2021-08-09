using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentURD urd{get; init;}
public HL7V24SegmentURS urs{get; init;}
public HL7V24SegmentDSP dsp{get; init;}
public HL7V24SegmentDSC dsc{get; init;}


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

        public HL7V24TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.urd = new HL7V24SegmentURD(this.message);
this.urs = new HL7V24SegmentURS(this.message);
this.dsp = new HL7V24SegmentDSP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
