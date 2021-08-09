using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSLN_S34
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentSLT slt{ get; init; }


        public string Id { get { return @"SLN_S34"; } }
        public string MessageStructureId { get { return @"SLN_S34"; } }
        public string EventDescription { get { return @"Notification of sterilization lot"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V27TriggerEventSLN_S34(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.slt = new HL7V27SegmentSLT(this.message);

        }
    }
}
