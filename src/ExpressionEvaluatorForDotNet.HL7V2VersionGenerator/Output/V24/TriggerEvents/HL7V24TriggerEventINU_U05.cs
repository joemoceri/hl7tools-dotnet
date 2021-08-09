using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventINU_U05
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentEQU equ{get; init;}
public HL7V24SegmentINV inv{get; init;}
public HL7V24SegmentROL rol{get; init;}


        public string Id { get { return @"INU_U05"; } }
        public string MessageStructureId { get { return @"INU_U05"; } }
        public string EventDescription { get { return @"Automated equipment inventory update"; } }

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

        public HL7V24TriggerEventINU_U05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.inv = new HL7V24SegmentINV(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}
