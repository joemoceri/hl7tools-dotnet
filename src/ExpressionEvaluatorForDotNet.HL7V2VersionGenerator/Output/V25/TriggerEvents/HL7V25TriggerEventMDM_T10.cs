using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMDM_T10
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentEVN evn;
public readonly HL7V25SegmentPID pid;
public readonly HL7V25SegmentPV1 pv1;
public readonly HL7V25SegmentTXA txa;


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

        public HL7V25TriggerEventMDM_T10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.txa = new HL7V25SegmentTXA(this.message);

        }
    }
}
