using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSRM_S08
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentARQ arq;
public readonly HL7V25SegmentAPR apr;
public readonly HL7V25SegmentNTE nte;


        public string Id { get { return @"SRM_S08"; } }
        public string MessageStructureId { get { return @"SRM_S08"; } }
        public string EventDescription { get { return @"Schedule request - Modification of service/resource on appointment"; } }

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

        public HL7V25TriggerEventSRM_S08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.arq = new HL7V25SegmentARQ(this.message);
this.apr = new HL7V25SegmentAPR(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
