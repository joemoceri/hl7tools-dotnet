using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventVXR_V03
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentMSA msa;
public readonly HL7V231SegmentQRD qrd;
public readonly HL7V231SegmentQRF qrf;
public readonly HL7V231SegmentPID pid;
public readonly HL7V231SegmentPD1 pd1;
public readonly HL7V231SegmentNK1 nk1;


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
