using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventINR_U06
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentEQU equ;
private readonly HL7V271SegmentINV inv;
private readonly HL7V271SegmentROL rol;


        public string Id { get { return @"INR_U06"; } }
        public string MessageStructureId { get { return @"INR_U06"; } }
        public string EventDescription { get { return @"Automated equipment inventory request"; } }

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

        public HL7V271TriggerEventINR_U06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.equ = new HL7V271SegmentEQU(this.message);
this.inv = new HL7V271SegmentINV(this.message);
this.rol = new HL7V271SegmentROL(this.message);

        }
    }
}
