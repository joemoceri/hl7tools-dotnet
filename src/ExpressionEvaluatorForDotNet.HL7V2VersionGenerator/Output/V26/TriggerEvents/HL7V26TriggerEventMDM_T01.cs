using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMDM_T01
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentEVN evn;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentPV1 pv1;
public readonly HL7V26SegmentTXA txa;


        public string Id { get { return @"MDM_T01"; } }
        public string MessageStructureId { get { return @"MDM_T01"; } }
        public string EventDescription { get { return @"Original Document Notification"; } }

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

        public HL7V26TriggerEventMDM_T01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.txa = new HL7V26SegmentTXA(this.message);

        }
    }
}
