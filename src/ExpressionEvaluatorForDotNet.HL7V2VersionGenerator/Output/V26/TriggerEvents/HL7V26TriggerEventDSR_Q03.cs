using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventDSR_Q03
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentMSA msa{ get; init; }
public HL7V26SegmentERR err{ get; init; }
public HL7V26SegmentQAK qak{ get; init; }
public HL7V26SegmentQRD qrd{ get; init; }
public HL7V26SegmentQRF qrf{ get; init; }
public HL7V26SegmentDSP dsp{ get; init; }
public HL7V26SegmentDSC dsc{ get; init; }


        public string Id { get { return @"DSR_Q03"; } }
        public string MessageStructureId { get { return @"DSR_Q03"; } }
        public string EventDescription { get { return @"Deferred Response to a Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V26TriggerEventDSR_Q03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);
this.dsp = new HL7V26SegmentDSP(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
