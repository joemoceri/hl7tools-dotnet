using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventTCU_U10
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentEQU equ;
public readonly HL7V24SegmentTCC tcc;
public readonly HL7V24SegmentROL rol;


        public string Id { get { return @"TCU_U10"; } }
        public string MessageStructureId { get { return @"TCU_U10"; } }
        public string EventDescription { get { return @"Automated equipment test code settings update"; } }

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

        public HL7V24TriggerEventTCU_U10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.tcc = new HL7V24SegmentTCC(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
