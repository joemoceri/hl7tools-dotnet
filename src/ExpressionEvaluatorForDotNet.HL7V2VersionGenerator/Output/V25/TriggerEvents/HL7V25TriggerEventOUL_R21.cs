using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventOUL_R21
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentNTE nte{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


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

        public HL7V25TriggerEventOUL_R21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.nte = new HL7V25SegmentNTE(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
