using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventOMN_O07
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentNTE nte;


        public string Id { get { return @"OMN_O07"; } }
        public string MessageStructureId { get { return @"OMN_O07"; } }
        public string EventDescription { get { return @"Non-Stock Requisition Order"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            }
        }

        public HL7V251TriggerEventOMN_O07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}