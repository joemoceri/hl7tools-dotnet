using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRQC_I06
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentQRD qrd;
public readonly HL7V27SegmentQRF qrf;
public readonly HL7V27SegmentPID pid;
public readonly HL7V27SegmentNK1 nk1;
public readonly HL7V27SegmentGT1 gt1;
public readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"RQC_I06"; } }
        public string MessageStructureId { get { return @"RQC_I06"; } }
        public string EventDescription { get { return @"Request/receipt of clinical data listing"; } }

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

        public HL7V27TriggerEventRQC_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.qrd = new HL7V27SegmentQRD(this.message);
this.qrf = new HL7V27SegmentQRF(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.gt1 = new HL7V27SegmentGT1(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
