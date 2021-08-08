using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRQC_I06
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentQRD qrd;
private readonly HL7V26SegmentQRF qrf;
private readonly HL7V26SegmentPID pid;
private readonly HL7V26SegmentNK1 nk1;
private readonly HL7V26SegmentGT1 gt1;
private readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"RQC_I06"; } }
        public string MessageStructureId { get { return @"RQC_I06"; } }
        public string EventDescription { get { return @"Request Clinical Data Listing"; } }

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

        public HL7V26TriggerEventRQC_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.nk1 = new HL7V26SegmentNK1(this.message);
this.gt1 = new HL7V26SegmentGT1(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
