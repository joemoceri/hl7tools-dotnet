using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSRM_S06
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentARQ arq;
public readonly HL7V27SegmentAPR apr;
public readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"SRM_S06"; } }
        public string MessageStructureId { get { return @"SRM_S06"; } }
        public string EventDescription { get { return @"Request appointment deletion"; } }

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

        public HL7V27TriggerEventSRM_S06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.arq = new HL7V27SegmentARQ(this.message);
this.apr = new HL7V27SegmentAPR(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
