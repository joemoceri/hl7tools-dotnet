using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRQC_I05
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentQRD qrd;
public readonly HL7V251SegmentQRF qrf;
public readonly HL7V251SegmentPID pid;
public readonly HL7V251SegmentNK1 nk1;
public readonly HL7V251SegmentGT1 gt1;
public readonly HL7V251SegmentNTE nte;


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

        public HL7V251TriggerEventRQC_I05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.nk1 = new HL7V251SegmentNK1(this.message);
this.gt1 = new HL7V251SegmentGT1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}