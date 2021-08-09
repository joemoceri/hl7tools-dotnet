using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventEHC_E13
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentMSA msa{get; init;}
public HL7V28SegmentERR err{get; init;}
public HL7V28SegmentRFI rfi{get; init;}
public HL7V28SegmentCTD ctd{get; init;}
public HL7V28SegmentIVC ivc{get; init;}
public HL7V28SegmentPSS pss{get; init;}
public HL7V28SegmentPSG psg{get; init;}
public HL7V28SegmentPID pid{get; init;}
public HL7V28SegmentPSL psl{get; init;}


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
