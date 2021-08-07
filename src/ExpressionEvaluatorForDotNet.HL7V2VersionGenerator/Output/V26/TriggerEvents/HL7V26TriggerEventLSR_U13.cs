using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventLSR_U13
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentEQU equ;
public readonly HL7V26SegmentEQP eqp;
public readonly HL7V26SegmentROL rol;


        public string Id { get { return @"LSR_U13"; } }
        public string MessageStructureId { get { return @"LSR_U13"; } }
        public string EventDescription { get { return @"Automated Equipment Log/Service Request"; } }

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

        public HL7V26TriggerEventLSR_U13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.equ = new HL7V26SegmentEQU(this.message);
this.eqp = new HL7V26SegmentEQP(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}
