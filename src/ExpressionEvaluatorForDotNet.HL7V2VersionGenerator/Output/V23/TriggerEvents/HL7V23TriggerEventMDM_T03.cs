using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMDM_T03
    {
        public HL7V2Message message { get; init; }
        public HL7V23SegmentMSH msh{ get; init; }
public HL7V23SegmentEVN evn{ get; init; }
public HL7V23SegmentPID pid{ get; init; }
public HL7V23SegmentPV1 pv1{ get; init; }
public HL7V23SegmentTXA txa{ get; init; }


        public string Id { get { return @"MDM_T03"; } }
        public string MessageStructureId { get { return @"MDM_T03"; } }
        public string EventDescription { get { return @"Document status change notification"; } }

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

        public HL7V23TriggerEventMDM_T03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.evn = new HL7V23SegmentEVN(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.pv1 = new HL7V23SegmentPV1(this.message);
this.txa = new HL7V23SegmentTXA(this.message);

        }
    }
}
