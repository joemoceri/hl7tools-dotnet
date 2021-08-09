using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventLSU_U12
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentEQU equ{get; init;}
public HL7V26SegmentEQP eqp{get; init;}
public HL7V26SegmentROL rol{get; init;}


        public string Id { get { return @"LSU_U12"; } }
        public string MessageStructureId { get { return @"LSU_U12"; } }
        public string EventDescription { get { return @"Automated Equipment Log/Service Update"; } }

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

        public HL7V26TriggerEventLSU_U12(HL7V2Message message)
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
