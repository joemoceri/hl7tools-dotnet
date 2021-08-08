using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventEHC_E13
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentMSA msa;
private readonly HL7V28SegmentERR err;
private readonly HL7V28SegmentRFI rfi;
private readonly HL7V28SegmentCTD ctd;
private readonly HL7V28SegmentIVC ivc;
private readonly HL7V28SegmentPSS pss;
private readonly HL7V28SegmentPSG psg;
private readonly HL7V28SegmentPID pid;
private readonly HL7V28SegmentPSL psl;


        public string Id { get { return @"EHC_E13"; } }
        public string MessageStructureId { get { return @"EHC_E13"; } }
        public string EventDescription { get { return @"Additional Information Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

                    };
            }
        }

        public HL7V28TriggerEventEHC_E13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.rfi = new HL7V28SegmentRFI(this.message);
this.ctd = new HL7V28SegmentCTD(this.message);
this.ivc = new HL7V28SegmentIVC(this.message);
this.pss = new HL7V28SegmentPSS(this.message);
this.psg = new HL7V28SegmentPSG(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.psl = new HL7V28SegmentPSL(this.message);

        }
    }
}
