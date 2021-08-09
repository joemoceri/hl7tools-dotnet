using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventESU_U01
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentEQU equ{ get; init; }
public HL7V25SegmentISD isd{ get; init; }
public HL7V25SegmentROL rol{ get; init; }


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

        public HL7V25TriggerEventESU_U01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.equ = new HL7V25SegmentEQU(this.message);
this.isd = new HL7V25SegmentISD(this.message);
this.rol = new HL7V25SegmentROL(this.message);

        }
    }
}
