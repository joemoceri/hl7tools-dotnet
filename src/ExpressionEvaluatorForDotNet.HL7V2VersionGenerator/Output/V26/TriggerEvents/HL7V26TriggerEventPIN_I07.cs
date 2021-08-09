using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventPIN_I07
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentPID pid{ get; init; }
public HL7V26SegmentNK1 nk1{ get; init; }
public HL7V26SegmentNTE nte{ get; init; }


        public string Id { get { return @"PIN_I07"; } }
        public string MessageStructureId { get { return @"PIN_I07"; } }
        public string EventDescription { get { return @"Unsolicited Insurance Information"; } }

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

        public HL7V26TriggerEventPIN_I07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.nk1 = new HL7V26SegmentNK1(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
