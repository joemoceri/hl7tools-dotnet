using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFR_M10
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentMSA msa;
public readonly HL7V24SegmentERR err;
public readonly HL7V24SegmentQRD qrd;
public readonly HL7V24SegmentQRF qrf;
public readonly HL7V24SegmentMFI mfi;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"MFR_M10"; } }
        public string MessageStructureId { get { return @"MFR_M10"; } }
        public string EventDescription { get { return @"Master Files Response - Test/observation batteries master file"; } }

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

        public HL7V24TriggerEventMFR_M10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
