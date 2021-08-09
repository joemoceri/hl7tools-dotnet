using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventORU_W01
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"ORU_W01"; } }
        public string MessageStructureId { get { return @"ORU_W01"; } }
        public string EventDescription { get { return @"Waveform result, unsolicited transmission of requested information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V251TriggerEventORU_W01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
