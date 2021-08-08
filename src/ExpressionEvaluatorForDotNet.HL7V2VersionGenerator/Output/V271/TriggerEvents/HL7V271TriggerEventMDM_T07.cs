using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventMDM_T07
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentEVN evn;
private readonly HL7V271SegmentPID pid;
private readonly HL7V271SegmentPV1 pv1;
private readonly HL7V271SegmentTXA txa;
private readonly HL7V271SegmentCON con;


        public string Id { get { return @"MDM_T07"; } }
        public string MessageStructureId { get { return @"MDM_T07"; } }
        public string EventDescription { get { return @"Document edit notification"; } }

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

        public HL7V271TriggerEventMDM_T07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.txa = new HL7V271SegmentTXA(this.message);
this.con = new HL7V271SegmentCON(this.message);

        }
    }
}
