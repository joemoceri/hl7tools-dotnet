using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRQP_I04
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentPID pid{ get; init; }
public HL7V23SegmentNK1 nk1{ get; init; }
public HL7V23SegmentGT1 gt1{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }


        public string Id { get { return @"RQP_I04"; } }
        public string MessageStructureId { get { return @"RQP_I04"; } }
        public string EventDescription { get { return @"Request patient demographics"; } }

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

        public HL7V23TriggerEventRQP_I04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.nk1 = new HL7V23SegmentNK1(this.message);
this.gt1 = new HL7V23SegmentGT1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
