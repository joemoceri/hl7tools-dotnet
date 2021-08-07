using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSRM_S01
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentARQ arq;
public readonly HL7V24SegmentAPR apr;
public readonly HL7V24SegmentNTE nte;


        public string Id { get { return @"SRM_S01"; } }
        public string MessageStructureId { get { return @"SRM_S01"; } }
        public string EventDescription { get { return @"Schedule request - New appointment booking"; } }

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

        public HL7V24TriggerEventSRM_S01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.arq = new HL7V24SegmentARQ(this.message);
this.apr = new HL7V24SegmentAPR(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
