using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRQC_I05
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentQRD qrd;
public readonly HL7V271SegmentQRF qrf;
public readonly HL7V271SegmentPID pid;
public readonly HL7V271SegmentNK1 nk1;
public readonly HL7V271SegmentGT1 gt1;
public readonly HL7V271SegmentNTE nte;


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

        public HL7V271TriggerEventRQC_I05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.qrd = new HL7V271SegmentQRD(this.message);
this.qrf = new HL7V271SegmentQRF(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.gt1 = new HL7V271SegmentGT1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
