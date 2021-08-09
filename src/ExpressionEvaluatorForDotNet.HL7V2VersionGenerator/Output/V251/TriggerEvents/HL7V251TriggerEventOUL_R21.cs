using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventOUL_R21
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentNTE nte{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"OUL_R21"; } }
        public string MessageStructureId { get { return @"OUL_R21"; } }
        public string EventDescription { get { return @"Unsolicited laboratory observation"; } }

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

        public HL7V251TriggerEventOUL_R21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
