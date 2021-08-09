using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventVXR_V03
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentMSA msa{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentQRD qrd{ get; init; }
public HL7V26SegmentQRF qrf{ get; init; }
public HL7V26SegmentPID pid{ get; init; }
public HL7V26SegmentPD1 pd1{ get; init; }
public HL7V26SegmentNK1 nk1{ get; init; }
public HL7V26SegmentGT1 gt1{ get; init; }


        public string Id { get { return @"VXR_V03"; } }
        public string MessageStructureId { get { return @"VXR_V03"; } }
        public string EventDescription { get { return @"Vaccination Record Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V26TriggerEventVXR_V03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pd1 = new HL7V26SegmentPD1(this.message);
this.nk1 = new HL7V26SegmentNK1(this.message);
this.gt1 = new HL7V26SegmentGT1(this.message);

        }
    }
}
