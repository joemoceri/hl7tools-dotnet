using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventREF_I13
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentRF1 rf1{ get; init; }
public HL7V24SegmentPID pid{ get; init; }
public HL7V24SegmentNK1 nk1{ get; init; }
public HL7V24SegmentGT1 gt1{ get; init; }
public HL7V24SegmentACC acc{ get; init; }
public HL7V24SegmentDG1 dg1{ get; init; }
public HL7V24SegmentDRG drg{ get; init; }
public HL7V24SegmentAL1 al1{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }


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

        public HL7V24TriggerEventREF_I13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.rf1 = new HL7V24SegmentRF1(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.nk1 = new HL7V24SegmentNK1(this.message);
this.gt1 = new HL7V24SegmentGT1(this.message);
this.acc = new HL7V24SegmentACC(this.message);
this.dg1 = new HL7V24SegmentDG1(this.message);
this.drg = new HL7V24SegmentDRG(this.message);
this.al1 = new HL7V24SegmentAL1(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
