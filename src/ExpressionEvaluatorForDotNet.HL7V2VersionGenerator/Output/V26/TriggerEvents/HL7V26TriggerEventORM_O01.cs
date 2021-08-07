using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventORM_O01
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"ORM_O01"; } }
        public string MessageStructureId { get { return @"ORM_O01"; } }
        public string EventDescription { get { return @"General Order Message"; } }

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

        public HL7V26TriggerEventORM_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
