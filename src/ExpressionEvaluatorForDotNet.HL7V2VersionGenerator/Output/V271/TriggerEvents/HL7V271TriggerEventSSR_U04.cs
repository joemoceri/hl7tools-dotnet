using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSSR_U04
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentEQU equ;
public readonly HL7V271SegmentROL rol;


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

        public HL7V271TriggerEventSSR_U04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.equ = new HL7V271SegmentEQU(this.message);
this.rol = new HL7V271SegmentROL(this.message);

        }
    }
}
