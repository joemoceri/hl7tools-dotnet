using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventLSR_U13
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentEQU equ{get; init;}
public HL7V251SegmentEQP eqp{get; init;}
public HL7V251SegmentROL rol{get; init;}


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

        public HL7V251TriggerEventLSR_U13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.equ = new HL7V251SegmentEQU(this.message);
this.eqp = new HL7V251SegmentEQP(this.message);
this.rol = new HL7V251SegmentROL(this.message);

        }
    }
}
