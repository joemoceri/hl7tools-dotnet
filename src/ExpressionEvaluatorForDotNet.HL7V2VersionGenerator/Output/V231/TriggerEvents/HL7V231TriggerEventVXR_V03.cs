using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventVXR_V03
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMSA msa{ get; init; }
public HL7V231SegmentQRD qrd{ get; init; }
public HL7V231SegmentQRF qrf{ get; init; }
public HL7V231SegmentPID pid{ get; init; }
public HL7V231SegmentPD1 pd1{ get; init; }
public HL7V231SegmentNK1 nk1{ get; init; }


        public string Id { get { return @"VXR_V03"; } }
        public string MessageStructureId { get { return @"VXR_V03"; } }
        public string EventDescription { get { return @"Vaccination record response"; } }

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

        public HL7V231TriggerEventVXR_V03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.nk1 = new HL7V231SegmentNK1(this.message);

        }
    }
}
