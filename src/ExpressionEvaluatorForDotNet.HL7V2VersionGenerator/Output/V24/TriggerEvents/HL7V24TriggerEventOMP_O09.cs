using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventOMP_O09
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentNTE nte{get; init;}


        public string Id { get { return @"OMP_O09"; } }
        public string MessageStructureId { get { return @"OMP_O09"; } }
        public string EventDescription { get { return @"Pharmacy/treatment order"; } }

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

        public HL7V24TriggerEventOMP_O09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
