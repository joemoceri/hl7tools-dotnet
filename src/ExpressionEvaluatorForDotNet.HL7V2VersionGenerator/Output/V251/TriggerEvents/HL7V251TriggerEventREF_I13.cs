using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventREF_I13
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentRF1 rf1;
public readonly HL7V251SegmentPID pid;
public readonly HL7V251SegmentNK1 nk1;
public readonly HL7V251SegmentGT1 gt1;
public readonly HL7V251SegmentACC acc;
public readonly HL7V251SegmentDG1 dg1;
public readonly HL7V251SegmentDRG drg;
public readonly HL7V251SegmentAL1 al1;
public readonly HL7V251SegmentNTE nte;


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

        public HL7V251TriggerEventREF_I13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.rf1 = new HL7V251SegmentRF1(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.nk1 = new HL7V251SegmentNK1(this.message);
this.gt1 = new HL7V251SegmentGT1(this.message);
this.acc = new HL7V251SegmentACC(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.al1 = new HL7V251SegmentAL1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
