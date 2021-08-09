using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventEHC_E13
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentMSA msa{get; init;}
public HL7V27SegmentERR err{get; init;}
public HL7V27SegmentRFI rfi{get; init;}
public HL7V27SegmentCTD ctd{get; init;}
public HL7V27SegmentIVC ivc{get; init;}
public HL7V27SegmentPSS pss{get; init;}
public HL7V27SegmentPSG psg{get; init;}
public HL7V27SegmentPID pid{get; init;}
public HL7V27SegmentPSL psl{get; init;}


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

        public HL7V27TriggerEventEHC_E13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
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
