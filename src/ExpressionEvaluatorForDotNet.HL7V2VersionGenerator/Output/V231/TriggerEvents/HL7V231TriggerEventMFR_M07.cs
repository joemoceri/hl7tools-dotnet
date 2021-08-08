using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFR_M07
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentMSA msa;
private readonly HL7V231SegmentERR err;
private readonly HL7V231SegmentQRD qrd;
private readonly HL7V231SegmentQRF qrf;
private readonly HL7V231SegmentMFI mfi;
private readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"MFR_M07"; } }
        public string MessageStructureId { get { return @"MFR_M07"; } }
        public string EventDescription { get { return @"Master Files Response - Clinical study without phases but with schedules"; } }

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

        public HL7V231TriggerEventMFR_M07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);
this.mfi = new HL7V231SegmentMFI(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
