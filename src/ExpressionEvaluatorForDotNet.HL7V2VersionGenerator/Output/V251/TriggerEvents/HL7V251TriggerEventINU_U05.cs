using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventINU_U05
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentEQU equ{ get; init; }
public HL7V251SegmentINV inv{ get; init; }
public HL7V251SegmentROL rol{ get; init; }


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

        public HL7V251TriggerEventINU_U05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.equ = new HL7V251SegmentEQU(this.message);
this.inv = new HL7V251SegmentINV(this.message);
this.rol = new HL7V251SegmentROL(this.message);

        }
    }
}
