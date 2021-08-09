using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventRGV_O01
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentNTE nte{ get; init; }


        public string Id { get { return @"RGV_O01"; } }
        public string MessageStructureId { get { return @"RGV_O01"; } }
        public string EventDescription { get { return @"Pharmacy/treatment give message"; } }

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

        public HL7V22TriggerEventRGV_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.nte = new HL7V22SegmentNTE(this.message);

        }
    }
}
