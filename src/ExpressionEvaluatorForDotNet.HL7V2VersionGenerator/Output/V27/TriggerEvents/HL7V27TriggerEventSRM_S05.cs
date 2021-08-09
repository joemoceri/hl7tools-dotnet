using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSRM_S05
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentARQ arq{get; init;}
public HL7V27SegmentAPR apr{get; init;}
public HL7V27SegmentNTE nte{get; init;}


        public string Id { get { return @"SRM_S05"; } }
        public string MessageStructureId { get { return @"SRM_S05"; } }
        public string EventDescription { get { return @"Request appointment discontinuation"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

                    };
            }
        }

        public HL7V27TriggerEventSRM_S05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.arq = new HL7V27SegmentARQ(this.message);
this.apr = new HL7V27SegmentAPR(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
