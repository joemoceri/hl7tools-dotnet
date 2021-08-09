using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRQP_I04
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentPID pid{ get; init; }
public HL7V25SegmentNK1 nk1{ get; init; }
public HL7V25SegmentGT1 gt1{ get; init; }
public HL7V25SegmentNTE nte{ get; init; }


        public string Id { get { return @"RQP_I04"; } }
        public string MessageStructureId { get { return @"RQP_I04"; } }
        public string EventDescription { get { return @"Request for patient demographic data"; } }

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

        public HL7V25TriggerEventRQP_I04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.nk1 = new HL7V25SegmentNK1(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
