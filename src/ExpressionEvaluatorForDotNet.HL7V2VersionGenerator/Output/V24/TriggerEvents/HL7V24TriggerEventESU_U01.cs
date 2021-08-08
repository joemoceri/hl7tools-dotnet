using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventESU_U01
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEQU equ;
private readonly HL7V24SegmentISD isd;
private readonly HL7V24SegmentROL rol;


        public string Id { get { return @"ESU_U01"; } }
        public string MessageStructureId { get { return @"ESU_U01"; } }
        public string EventDescription { get { return @"Automated equipment status update"; } }

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

        public HL7V24TriggerEventESU_U01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.isd = new HL7V24SegmentISD(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
