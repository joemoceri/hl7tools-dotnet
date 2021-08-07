using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventOMD_O01
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentNTE nte;


        public string Id { get { return @"OMD_O01"; } }
        public string MessageStructureId { get { return @"OMD_O01"; } }
        public string EventDescription { get { return @"Dietary order"; } }

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

        public HL7V231TriggerEventOMD_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
