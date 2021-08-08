using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventORM_O01
    {
        private readonly HL7V2Message message;
        private readonly HL7V21SegmentMSH msh;
private readonly HL7V21SegmentNTE nte;


        public string Id { get { return @"ORM_O01"; } }
        public string MessageStructureId { get { return @"ORM_O01"; } }
        public string EventDescription { get { return @"Order Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventORM_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.nte = new HL7V21SegmentNTE(this.message);

        }
    }
}
