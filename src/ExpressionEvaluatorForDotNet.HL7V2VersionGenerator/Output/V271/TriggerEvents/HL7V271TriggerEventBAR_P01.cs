using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventBAR_P01
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentEVN evn{get; init;}
public HL7V271SegmentPID pid{get; init;}
public HL7V271SegmentPD1 pd1{get; init;}
public HL7V271SegmentROL rol{get; init;}


        public string Id { get { return @"BAR_P01"; } }
        public string MessageStructureId { get { return @"BAR_P01"; } }
        public string EventDescription { get { return @"Add patient accounts"; } }

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

        public HL7V271TriggerEventBAR_P01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.rol = new HL7V271SegmentROL(this.message);

        }
    }
}
