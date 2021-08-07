using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMDM_T03
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEVN evn;
public readonly HL7V251SegmentPID pid;
public readonly HL7V251SegmentPV1 pv1;
public readonly HL7V251SegmentTXA txa;


        public string Id { get { return @"MDM_T03"; } }
        public string MessageStructureId { get { return @"MDM_T03"; } }
        public string EventDescription { get { return @"Document status change notification "; } }

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

        public HL7V251TriggerEventMDM_T03(HL7V2Message message)
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
