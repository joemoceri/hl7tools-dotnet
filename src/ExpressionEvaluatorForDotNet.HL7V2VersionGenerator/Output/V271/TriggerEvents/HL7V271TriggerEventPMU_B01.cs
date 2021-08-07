using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventPMU_B01
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentEVN evn;
public readonly HL7V271SegmentSTF stf;
public readonly HL7V271SegmentPRA pra;
public readonly HL7V271SegmentORG org;
public readonly HL7V271SegmentAFF aff;
public readonly HL7V271SegmentLAN lan;
public readonly HL7V271SegmentEDU edu;
public readonly HL7V271SegmentCER cer;
public readonly HL7V271SegmentNK1 nk1;
public readonly HL7V271SegmentROL rol;


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

        public HL7V271TriggerEventPMU_B01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.stf = new HL7V271SegmentSTF(this.message);
this.pra = new HL7V271SegmentPRA(this.message);
this.org = new HL7V271SegmentORG(this.message);
this.aff = new HL7V271SegmentAFF(this.message);
this.lan = new HL7V271SegmentLAN(this.message);
this.edu = new HL7V271SegmentEDU(this.message);
this.cer = new HL7V271SegmentCER(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.rol = new HL7V271SegmentROL(this.message);

        }
    }
}
