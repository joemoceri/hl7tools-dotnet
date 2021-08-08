using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventBAR_P05
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentEVN evn;
private readonly HL7V28SegmentPID pid;
private readonly HL7V28SegmentPD1 pd1;
private readonly HL7V28SegmentPRT prt;
private readonly HL7V28SegmentROL rol;


        public string Id { get { return @"BAR_P05"; } }
        public string MessageStructureId { get { return @"BAR_P05"; } }
        public string EventDescription { get { return @"Update account"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V28TriggerEventBAR_P05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pd1 = new HL7V28SegmentPD1(this.message);
this.prt = new HL7V28SegmentPRT(this.message);
this.rol = new HL7V28SegmentROL(this.message);

        }
    }
}
