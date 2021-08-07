using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSMD_S32
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentSDD sdd;


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

        public HL7V27TriggerEventSMD_S32(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.sdd = new HL7V27SegmentSDD(this.message);

        }
    }
}
