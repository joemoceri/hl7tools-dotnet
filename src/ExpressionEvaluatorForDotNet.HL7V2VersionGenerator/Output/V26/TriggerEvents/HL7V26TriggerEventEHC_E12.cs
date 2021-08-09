using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventEHC_E12
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentRFI rfi{get; init;}
public HL7V26SegmentCTD ctd{get; init;}
public HL7V26SegmentIVC ivc{get; init;}
public HL7V26SegmentPSS pss{get; init;}
public HL7V26SegmentPSG psg{get; init;}
public HL7V26SegmentPID pid{get; init;}
public HL7V26SegmentPSL psl{get; init;}


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

        public HL7V26TriggerEventEHC_E12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.rfi = new HL7V26SegmentRFI(this.message);
this.ctd = new HL7V26SegmentCTD(this.message);
this.ivc = new HL7V26SegmentIVC(this.message);
this.pss = new HL7V26SegmentPSS(this.message);
this.psg = new HL7V26SegmentPSG(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.psl = new HL7V26SegmentPSL(this.message);

        }
    }
}
