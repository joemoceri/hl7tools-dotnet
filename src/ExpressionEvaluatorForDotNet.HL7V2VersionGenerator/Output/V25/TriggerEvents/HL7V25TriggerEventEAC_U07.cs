using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventEAC_U07
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEQU equ{get; init;}
public HL7V25SegmentROL rol{get; init;}


        public string Id { get { return @"EAC_U07"; } }
        public string MessageStructureId { get { return @"EAC_U07"; } }
        public string EventDescription { get { return @"Automated equipment command"; } }

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

        public HL7V25TriggerEventEAC_U07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.equ = new HL7V25SegmentEQU(this.message);
this.rol = new HL7V25SegmentROL(this.message);

        }
    }
}
