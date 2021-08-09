using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMFR_M07
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentMSA msa{ get; init; }
public HL7V26SegmentERR err{ get; init; }
public HL7V26SegmentQAK qak{ get; init; }
public HL7V26SegmentQRD qrd{ get; init; }
public HL7V26SegmentQRF qrf{ get; init; }
public HL7V26SegmentMFI mfi{ get; init; }
public HL7V26SegmentDSC dsc{ get; init; }


        public string Id { get { return @"MFR_M07"; } }
        public string MessageStructureId { get { return @"MFR_M07"; } }
        public string EventDescription { get { return @"Master files response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V26TriggerEventMFR_M07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);
this.mfi = new HL7V26SegmentMFI(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
