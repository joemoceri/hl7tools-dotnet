using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventEHC_E12
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentRFI rfi;
public readonly HL7V28SegmentCTD ctd;
public readonly HL7V28SegmentIVC ivc;
public readonly HL7V28SegmentPSS pss;
public readonly HL7V28SegmentPSG psg;
public readonly HL7V28SegmentPID pid;
public readonly HL7V28SegmentPSL psl;


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

        public HL7V28TriggerEventEHC_E12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
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
