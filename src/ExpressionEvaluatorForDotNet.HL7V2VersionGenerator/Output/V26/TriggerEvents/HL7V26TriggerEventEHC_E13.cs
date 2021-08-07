using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventEHC_E13
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentERR err;
public readonly HL7V26SegmentRFI rfi;
public readonly HL7V26SegmentCTD ctd;
public readonly HL7V26SegmentIVC ivc;
public readonly HL7V26SegmentPSS pss;
public readonly HL7V26SegmentPSG psg;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentPSL psl;


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

        public HL7V26TriggerEventEHC_E13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
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
