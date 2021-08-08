using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventADT_A50
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentEVN evn;
private readonly HL7V28SegmentPID pid;
private readonly HL7V28SegmentPD1 pd1;
private readonly HL7V28SegmentMRG mrg;
private readonly HL7V28SegmentPV1 pv1;


        public string Id { get { return @"ADT_A50"; } }
        public string MessageStructureId { get { return @"ADT_A50"; } }
        public string EventDescription { get { return @"Change visit number"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V28TriggerEventADT_A50(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pd1 = new HL7V28SegmentPD1(this.message);
this.mrg = new HL7V28SegmentMRG(this.message);
this.pv1 = new HL7V28SegmentPV1(this.message);

        }
    }
}
