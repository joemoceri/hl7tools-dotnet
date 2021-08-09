using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventTCU_U10
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEQU equ{get; init;}
public HL7V24SegmentTCC tcc{get; init;}
public HL7V24SegmentROL rol{get; init;}


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
