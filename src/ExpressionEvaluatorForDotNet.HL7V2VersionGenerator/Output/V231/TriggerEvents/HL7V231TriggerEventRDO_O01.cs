using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRDO_O01
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentNTE nte{get; init;}


        public string Id { get { return @"RDO_O01"; } }
        public string MessageStructureId { get { return @"RDO_O01"; } }
        public string EventDescription { get { return @"Pharmacy/treatment Order Message"; } }

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

        public HL7V231TriggerEventRDO_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
