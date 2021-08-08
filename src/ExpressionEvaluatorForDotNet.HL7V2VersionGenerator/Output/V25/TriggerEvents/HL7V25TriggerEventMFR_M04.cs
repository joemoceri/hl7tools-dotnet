using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFR_M04
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentMSA msa;
private readonly HL7V25SegmentERR err;
private readonly HL7V25SegmentQAK qak;
private readonly HL7V25SegmentQRD qrd;
private readonly HL7V25SegmentQRF qrf;
private readonly HL7V25SegmentMFI mfi;
private readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"MFR_M04"; } }
        public string MessageStructureId { get { return @"MFR_M04"; } }
        public string EventDescription { get { return @"Master Files Response - Charge description master file"; } }

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

        public HL7V25TriggerEventMFR_M04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);
this.mfi = new HL7V25SegmentMFI(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
