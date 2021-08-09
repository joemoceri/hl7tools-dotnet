using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventCSU_C11
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }


        public string Id { get { return @"CSU_C11"; } }
        public string MessageStructureId { get { return @"CSU_C11"; } }
        public string EventDescription { get { return @"Patient completes a phase of the clinical trial"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V271TriggerEventCSU_C11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);

        }
    }
}
