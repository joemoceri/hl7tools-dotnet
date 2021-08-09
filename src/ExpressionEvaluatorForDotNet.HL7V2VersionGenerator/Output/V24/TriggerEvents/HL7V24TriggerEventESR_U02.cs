using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventESR_U02
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEQU equ{get; init;}
public HL7V24SegmentROL rol{get; init;}


        public string Id { get { return @"ESR_U02"; } }
        public string MessageStructureId { get { return @"ESR_U02"; } }
        public string EventDescription { get { return @"Automated equipment status request"; } }

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

        public HL7V24TriggerEventESR_U02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
