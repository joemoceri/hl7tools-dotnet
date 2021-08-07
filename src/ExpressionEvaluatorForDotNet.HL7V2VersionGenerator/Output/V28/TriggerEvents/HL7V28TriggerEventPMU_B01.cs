using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventPMU_B01
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentEVN evn;
public readonly HL7V28SegmentSTF stf;
public readonly HL7V28SegmentPRA pra;
public readonly HL7V28SegmentORG org;
public readonly HL7V28SegmentAFF aff;
public readonly HL7V28SegmentLAN lan;
public readonly HL7V28SegmentEDU edu;
public readonly HL7V28SegmentCER cer;
public readonly HL7V28SegmentNK1 nk1;
public readonly HL7V28SegmentPRT prt;
public readonly HL7V28SegmentROL rol;


        public string Id { get { return @"PMU_B01"; } }
        public string MessageStructureId { get { return @"PMU_B01"; } }
        public string EventDescription { get { return @"Add personnel record"; } }

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

        public HL7V28TriggerEventPMU_B01(HL7V2Message message)
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
