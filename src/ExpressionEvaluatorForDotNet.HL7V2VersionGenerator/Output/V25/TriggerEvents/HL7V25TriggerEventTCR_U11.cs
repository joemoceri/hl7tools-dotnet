using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventTCR_U11
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentEQU equ;
public readonly HL7V25SegmentROL rol;


        public string Id { get { return @"TCR_U11"; } }
        public string MessageStructureId { get { return @"TCR_U11"; } }
        public string EventDescription { get { return @"Automated Equipment Test Code Settings Request"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
                    };
            }
        }

        public HL7V25TriggerEventTCR_U11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.equ = new HL7V25SegmentEQU(this.message);
this.rol = new HL7V25SegmentROL(this.message);

        }
    }
}
