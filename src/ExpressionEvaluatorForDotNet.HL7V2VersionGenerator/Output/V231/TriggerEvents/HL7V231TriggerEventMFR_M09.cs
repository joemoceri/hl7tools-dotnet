using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFR_M09
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentMSA msa;
public readonly HL7V231SegmentERR err;
public readonly HL7V231SegmentQRD qrd;
public readonly HL7V231SegmentQRF qrf;
public readonly HL7V231SegmentMFI mfi;
public readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"MFR_M09"; } }
        public string MessageStructureId { get { return @"MFR_M09"; } }
        public string EventDescription { get { return @"Master Files Response - Test/Observation"; } }

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

        public HL7V231TriggerEventMFR_M09(HL7V2Message message)
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
