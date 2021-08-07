using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventLSR_U13
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentEQU equ;
public readonly HL7V24SegmentEQP eqp;
public readonly HL7V24SegmentROL rol;


        public string Id { get { return @"LSR_U13"; } }
        public string MessageStructureId { get { return @"LSR_U13"; } }
        public string EventDescription { get { return @"Automated equipment log/service request"; } }

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

        public HL7V24TriggerEventLSR_U13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.eqp = new HL7V24SegmentEQP(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
