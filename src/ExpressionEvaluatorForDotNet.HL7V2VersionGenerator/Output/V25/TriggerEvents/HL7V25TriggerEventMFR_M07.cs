using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFR_M07
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentMSA msa{ get; init; }
public HL7V25SegmentERR err{ get; init; }
public HL7V25SegmentQAK qak{ get; init; }
public HL7V25SegmentQRD qrd{ get; init; }
public HL7V25SegmentQRF qrf{ get; init; }
public HL7V25SegmentMFI mfi{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


        public string Id { get { return @"MFR_M07"; } }
        public string MessageStructureId { get { return @"MFR_M07"; } }
        public string EventDescription { get { return @"Master Files Response - Clinical study without phases but with schedules master file"; } }

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

        public HL7V25TriggerEventMFR_M07(HL7V2Message message)
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
