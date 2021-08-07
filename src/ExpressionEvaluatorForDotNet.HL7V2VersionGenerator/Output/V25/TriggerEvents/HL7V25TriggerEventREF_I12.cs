using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventREF_I12
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentRF1 rf1;
public readonly HL7V25SegmentPID pid;
public readonly HL7V25SegmentNK1 nk1;
public readonly HL7V25SegmentGT1 gt1;
public readonly HL7V25SegmentACC acc;
public readonly HL7V25SegmentDG1 dg1;
public readonly HL7V25SegmentDRG drg;
public readonly HL7V25SegmentAL1 al1;
public readonly HL7V25SegmentNTE nte;


        public string Id { get { return @"REF_I12"; } }
        public string MessageStructureId { get { return @"REF_I12"; } }
        public string EventDescription { get { return @"Patient referral"; } }

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

        public HL7V25TriggerEventREF_I12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.rf1 = new HL7V25SegmentRF1(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);
this.acc = new HL7V25SegmentACC(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.drg = new HL7V25SegmentDRG(this.message);
this.al1 = new HL7V25SegmentAL1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
