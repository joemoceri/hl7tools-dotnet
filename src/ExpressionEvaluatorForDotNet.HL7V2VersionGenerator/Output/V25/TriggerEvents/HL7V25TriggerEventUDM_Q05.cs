using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentURD urd{get; init;}
public HL7V25SegmentURS urs{get; init;}
public HL7V25SegmentDSP dsp{get; init;}
public HL7V25SegmentDSC dsc{get; init;}


        public string Id { get { return @"UDM_Q05"; } }
        public string MessageStructureId { get { return @"UDM_Q05"; } }
        public string EventDescription { get { return @"Unsolicited Display Update"; } }

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

        public HL7V25TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.urd = new HL7V25SegmentURD(this.message);
this.urs = new HL7V25SegmentURS(this.message);
this.dsp = new HL7V25SegmentDSP(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
