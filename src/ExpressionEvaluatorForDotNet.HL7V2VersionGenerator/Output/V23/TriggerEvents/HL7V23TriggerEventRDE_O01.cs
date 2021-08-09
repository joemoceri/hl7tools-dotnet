using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRDE_O01
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentNTE nte{ get; init; }


        public string Id { get { return @"RDE_O01"; } }
        public string MessageStructureId { get { return @"RDE_O01"; } }
        public string EventDescription { get { return @"Pharmacy/treatment encoded order message"; } }

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

        public HL7V23TriggerEventRDE_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}
