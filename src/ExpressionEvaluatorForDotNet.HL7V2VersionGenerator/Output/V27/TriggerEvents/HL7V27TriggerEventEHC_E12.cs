using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventEHC_E12
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentRFI rfi;
private readonly HL7V27SegmentCTD ctd;
private readonly HL7V27SegmentIVC ivc;
private readonly HL7V27SegmentPSS pss;
private readonly HL7V27SegmentPSG psg;
private readonly HL7V27SegmentPID pid;
private readonly HL7V27SegmentPSL psl;


        public string Id { get { return @"EHC_E12"; } }
        public string MessageStructureId { get { return @"EHC_E12"; } }
        public string EventDescription { get { return @"Request Additional Information"; } }

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

        public HL7V27TriggerEventEHC_E12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.rfi = new HL7V27SegmentRFI(this.message);
this.ctd = new HL7V27SegmentCTD(this.message);
this.ivc = new HL7V27SegmentIVC(this.message);
this.pss = new HL7V27SegmentPSS(this.message);
this.psg = new HL7V27SegmentPSG(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.psl = new HL7V27SegmentPSL(this.message);

        }
    }
}
