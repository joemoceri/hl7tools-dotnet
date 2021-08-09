using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventEHC_E13
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentMSA msa{ get; init; }
public HL7V271SegmentERR err{ get; init; }
public HL7V271SegmentRFI rfi{ get; init; }
public HL7V271SegmentCTD ctd{ get; init; }
public HL7V271SegmentIVC ivc{ get; init; }
public HL7V271SegmentPSS pss{ get; init; }
public HL7V271SegmentPSG psg{ get; init; }
public HL7V271SegmentPID pid{ get; init; }
public HL7V271SegmentPSL psl{ get; init; }


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

        public HL7V271TriggerEventEHC_E13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.rfi = new HL7V271SegmentRFI(this.message);
this.ctd = new HL7V271SegmentCTD(this.message);
this.ivc = new HL7V271SegmentIVC(this.message);
this.pss = new HL7V271SegmentPSS(this.message);
this.psg = new HL7V271SegmentPSG(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.psl = new HL7V271SegmentPSL(this.message);

        }
    }
}
