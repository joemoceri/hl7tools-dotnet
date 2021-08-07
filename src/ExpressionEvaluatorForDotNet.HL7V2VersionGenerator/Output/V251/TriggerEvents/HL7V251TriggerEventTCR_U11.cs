using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventTCR_U11
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEQU equ;
public readonly HL7V251SegmentROL rol;


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

        public HL7V251TriggerEventTCR_U11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.equ = new HL7V251SegmentEQU(this.message);
this.rol = new HL7V251SegmentROL(this.message);

        }
    }
}
