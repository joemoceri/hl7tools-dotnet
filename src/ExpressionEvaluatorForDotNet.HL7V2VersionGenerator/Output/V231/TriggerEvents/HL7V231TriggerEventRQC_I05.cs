using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRQC_I05
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentQRD qrd{get; init;}
public HL7V231SegmentQRF qrf{get; init;}
public HL7V231SegmentPID pid{get; init;}
public HL7V231SegmentNK1 nk1{get; init;}
public HL7V231SegmentGT1 gt1{get; init;}
public HL7V231SegmentNTE nte{get; init;}


        public string Id { get { return @"RQC_I05"; } }
        public string MessageStructureId { get { return @"RQC_I05"; } }
        public string EventDescription { get { return @"Request for patient clinical information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V231TriggerEventRQC_I05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.nk1 = new HL7V231SegmentNK1(this.message);
this.gt1 = new HL7V231SegmentGT1(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
