using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A20
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentEVN evn{ get; init; }
public HL7V251SegmentNPU npu{ get; init; }


        public string Id { get { return @"ADT_A20"; } }
        public string MessageStructureId { get { return @"ADT_A20"; } }
        public string EventDescription { get { return @"Bed Status Update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V251TriggerEventADT_A20(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.npu = new HL7V251SegmentNPU(this.message);

        }
    }
}
