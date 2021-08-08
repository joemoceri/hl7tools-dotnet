using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventDFT_P11
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentEVN evn;
private readonly HL7V251SegmentPID pid;
private readonly HL7V251SegmentPD1 pd1;
private readonly HL7V251SegmentROL rol;
private readonly HL7V251SegmentPV1 pv1;
private readonly HL7V251SegmentPV2 pv2;
private readonly HL7V251SegmentROL rol;
private readonly HL7V251SegmentDB1 db1;
private readonly HL7V251SegmentDG1 dg1;
private readonly HL7V251SegmentDRG drg;
private readonly HL7V251SegmentGT1 gt1;
private readonly HL7V251SegmentACC acc;


        public string Id { get { return @"DFT_P11"; } }
        public string MessageStructureId { get { return @"DFT_P11"; } }
        public string EventDescription { get { return @"Post Detail Financial Transactions - Expanded"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V251TriggerEventDFT_P11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.rol = new HL7V251SegmentROL(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.pv2 = new HL7V251SegmentPV2(this.message);
this.rol = new HL7V251SegmentROL(this.message);
this.db1 = new HL7V251SegmentDB1(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.gt1 = new HL7V251SegmentGT1(this.message);
this.acc = new HL7V251SegmentACC(this.message);

        }
    }
}
