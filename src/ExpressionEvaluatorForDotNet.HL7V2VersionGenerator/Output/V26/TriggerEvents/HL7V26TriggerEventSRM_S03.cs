using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSRM_S03
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentARQ arq{get; init;}
public HL7V26SegmentAPR apr{get; init;}
public HL7V26SegmentNTE nte{get; init;}


        public string Id { get { return @"SRM_S03"; } }
        public string MessageStructureId { get { return @"SRM_S03"; } }
        public string EventDescription { get { return @"Request Appointment Modification"; } }

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

        public HL7V26TriggerEventSRM_S03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.arq = new HL7V26SegmentARQ(this.message);
this.apr = new HL7V26SegmentAPR(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
