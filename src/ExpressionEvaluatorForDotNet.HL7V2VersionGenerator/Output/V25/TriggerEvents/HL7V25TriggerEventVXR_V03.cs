using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventVXR_V03
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentMSA msa{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentQRD qrd{get; init;}
public HL7V25SegmentQRF qrf{get; init;}
public HL7V25SegmentPID pid{get; init;}
public HL7V25SegmentPD1 pd1{get; init;}
public HL7V25SegmentNK1 nk1{get; init;}
public HL7V25SegmentGT1 gt1{get; init;}


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

        public HL7V25TriggerEventVXR_V03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);

        }
    }
}
