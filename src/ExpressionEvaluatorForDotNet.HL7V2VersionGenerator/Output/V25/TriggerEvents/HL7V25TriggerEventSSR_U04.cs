using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSSR_U04
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentEQU equ;
public readonly HL7V25SegmentROL rol;


        public string Id { get { return @"SSR_U04"; } }
        public string MessageStructureId { get { return @"SSR_U04"; } }
        public string EventDescription { get { return @"Specimen status request"; } }

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

        public HL7V25TriggerEventSSR_U04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.equ = new HL7V25SegmentEQU(this.message);
this.rol = new HL7V25SegmentROL(this.message);

        }
    }
}
