using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventDFT_P11
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEVN evn{get; init;}
public HL7V25SegmentPID pid{get; init;}
public HL7V25SegmentPD1 pd1{get; init;}
public HL7V25SegmentROL rol{get; init;}
public HL7V25SegmentPV1 pv1{get; init;}
public HL7V25SegmentPV2 pv2{get; init;}
public HL7V25SegmentROL rol{get; init;}
public HL7V25SegmentDB1 db1{get; init;}
public HL7V25SegmentDG1 dg1{get; init;}
public HL7V25SegmentDRG drg{get; init;}
public HL7V25SegmentGT1 gt1{get; init;}
public HL7V25SegmentACC acc{get; init;}


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

        public HL7V25TriggerEventDFT_P11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.rol = new HL7V25SegmentROL(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.pv2 = new HL7V25SegmentPV2(this.message);
this.rol = new HL7V25SegmentROL(this.message);
this.db1 = new HL7V25SegmentDB1(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.drg = new HL7V25SegmentDRG(this.message);
this.gt1 = new HL7V25SegmentGT1(this.message);
this.acc = new HL7V25SegmentACC(this.message);

        }
    }
}
