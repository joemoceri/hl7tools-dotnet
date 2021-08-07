using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFR_M06
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentERR err;
public readonly HL7V23SegmentQRD qrd;
public readonly HL7V23SegmentQRF qrf;
public readonly HL7V23SegmentMFI mfi;
public readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"MFR_M06"; } }
        public string MessageStructureId { get { return @"MFR_M06"; } }
        public string EventDescription { get { return @"Master Files Response - Clinical study with phases and schedules"; } }

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

        public HL7V23TriggerEventMFR_M06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
