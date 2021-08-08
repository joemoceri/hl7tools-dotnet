using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventREF_I13
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentRF1 rf1;
private readonly HL7V27SegmentPID pid;
private readonly HL7V27SegmentNK1 nk1;
private readonly HL7V27SegmentGT1 gt1;
private readonly HL7V27SegmentACC acc;
private readonly HL7V27SegmentDG1 dg1;
private readonly HL7V27SegmentDRG drg;
private readonly HL7V27SegmentAL1 al1;
private readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"REF_I13"; } }
        public string MessageStructureId { get { return @"REF_I13"; } }
        public string EventDescription { get { return @"Modify patient referral"; } }

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

        public HL7V27TriggerEventREF_I13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.rf1 = new HL7V27SegmentRF1(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.gt1 = new HL7V27SegmentGT1(this.message);
this.acc = new HL7V27SegmentACC(this.message);
this.dg1 = new HL7V27SegmentDG1(this.message);
this.drg = new HL7V27SegmentDRG(this.message);
this.al1 = new HL7V27SegmentAL1(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
