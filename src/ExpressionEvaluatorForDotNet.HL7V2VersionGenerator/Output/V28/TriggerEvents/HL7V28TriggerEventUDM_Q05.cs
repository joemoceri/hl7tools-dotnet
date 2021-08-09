using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentURD urd{get; init;}
public HL7V28SegmentURS urs{get; init;}
public HL7V28SegmentDSP dsp{get; init;}
public HL7V28SegmentDSC dsc{get; init;}


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

        public HL7V28TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.urd = new HL7V28SegmentURD(this.message);
this.urs = new HL7V28SegmentURS(this.message);
this.dsp = new HL7V28SegmentDSP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
