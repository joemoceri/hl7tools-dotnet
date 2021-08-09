using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSMD_S32
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}


        public string Id { get { return @"SMD_S32"; } }
        public string MessageStructureId { get { return @"SMD_S32"; } }
        public string EventDescription { get { return @"Request Anti-Microbial Device Cycle Data "; } }

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

        public HL7V26TriggerEventSMD_S32(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);

        }
    }
}
