using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMDM_T05
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentEVN evn;
private readonly HL7V23SegmentPID pid;
private readonly HL7V23SegmentPV1 pv1;
private readonly HL7V23SegmentTXA txa;


        public string Id { get { return @"MDM_T05"; } }
        public string MessageStructureId { get { return @"MDM_T05"; } }
        public string EventDescription { get { return @"Document addendum notification"; } }

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

        public HL7V23TriggerEventMDM_T05(HL7V2Message message)
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
