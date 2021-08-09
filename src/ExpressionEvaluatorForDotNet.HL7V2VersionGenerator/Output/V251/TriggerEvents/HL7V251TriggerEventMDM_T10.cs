using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMDM_T10
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentEVN evn{ get; init; }
public HL7V251SegmentPID pid{ get; init; }
public HL7V251SegmentPV1 pv1{ get; init; }
public HL7V251SegmentTXA txa{ get; init; }


        public string Id { get { return @"MDM_T10"; } }
        public string MessageStructureId { get { return @"MDM_T10"; } }
        public string EventDescription { get { return @"Document replacement notification and content"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V251TriggerEventMDM_T10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.txa = new HL7V251SegmentTXA(this.message);

        }
    }
}
