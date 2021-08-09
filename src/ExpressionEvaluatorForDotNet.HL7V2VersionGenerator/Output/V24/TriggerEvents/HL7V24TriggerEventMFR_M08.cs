using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFR_M08
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMSA msa{get; init;}
public HL7V24SegmentERR err{get; init;}
public HL7V24SegmentQRD qrd{get; init;}
public HL7V24SegmentQRF qrf{get; init;}
public HL7V24SegmentMFI mfi{get; init;}
public HL7V24SegmentDSC dsc{get; init;}


        public string Id { get { return @"MFR_M08"; } }
        public string MessageStructureId { get { return @"MFR_M08"; } }
        public string EventDescription { get { return @"Master Files Response - Test/observation (numeric) master file"; } }

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

        public HL7V24TriggerEventMFR_M08(HL7V2Message message)
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
