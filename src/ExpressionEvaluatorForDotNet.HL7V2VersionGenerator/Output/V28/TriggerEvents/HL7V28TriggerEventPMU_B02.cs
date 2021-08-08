using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventPMU_B02
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentEVN evn;
private readonly HL7V28SegmentSTF stf;
private readonly HL7V28SegmentPRA pra;
private readonly HL7V28SegmentORG org;
private readonly HL7V28SegmentAFF aff;
private readonly HL7V28SegmentLAN lan;
private readonly HL7V28SegmentEDU edu;
private readonly HL7V28SegmentCER cer;
private readonly HL7V28SegmentNK1 nk1;
private readonly HL7V28SegmentPRT prt;
private readonly HL7V28SegmentROL rol;


        public string Id { get { return @"PMU_B02"; } }
        public string MessageStructureId { get { return @"PMU_B02"; } }
        public string EventDescription { get { return @"Update personnel record"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V28TriggerEventPMU_B02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.stf = new HL7V28SegmentSTF(this.message);
this.pra = new HL7V28SegmentPRA(this.message);
this.org = new HL7V28SegmentORG(this.message);
this.aff = new HL7V28SegmentAFF(this.message);
this.lan = new HL7V28SegmentLAN(this.message);
this.edu = new HL7V28SegmentEDU(this.message);
this.cer = new HL7V28SegmentCER(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.prt = new HL7V28SegmentPRT(this.message);
this.rol = new HL7V28SegmentROL(this.message);

        }
    }
}
