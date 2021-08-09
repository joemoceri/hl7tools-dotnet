using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventLSU_U12
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentEQU equ{ get; init; }
public HL7V24SegmentEQP eqp{ get; init; }
public HL7V24SegmentROL rol{ get; init; }


        public string Id { get { return @"LSU_U12"; } }
        public string MessageStructureId { get { return @"LSU_U12"; } }
        public string EventDescription { get { return @"Automated equipment log/service update"; } }

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

        public HL7V24TriggerEventLSU_U12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.eqp = new HL7V24SegmentEQP(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
