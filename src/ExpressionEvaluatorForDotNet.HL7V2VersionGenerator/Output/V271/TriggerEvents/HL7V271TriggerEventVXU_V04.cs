using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventVXU_V04
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentPID pid{get; init;}
public HL7V271SegmentPD1 pd1{get; init;}
public HL7V271SegmentNK1 nk1{get; init;}
public HL7V271SegmentGT1 gt1{get; init;}


        public string Id { get { return @"VXU_V04"; } }
        public string MessageStructureId { get { return @"VXU_V04"; } }
        public string EventDescription { get { return @"Unsolicited vaccination record update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V271TriggerEventVXU_V04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.gt1 = new HL7V271SegmentGT1(this.message);

        }
    }
}
