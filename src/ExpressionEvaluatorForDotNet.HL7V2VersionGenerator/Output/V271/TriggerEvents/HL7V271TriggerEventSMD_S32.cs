using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSMD_S32
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentSDD sdd{get; init;}


        public string Id { get { return @"SMD_S32"; } }
        public string MessageStructureId { get { return @"SMD_S32"; } }
        public string EventDescription { get { return @"Request anti-microbial device cycle data"; } }

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

        public HL7V271TriggerEventSMD_S32(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.sdd = new HL7V271SegmentSDD(this.message);

        }
    }
}
