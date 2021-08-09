using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventCCF_I22
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentPID pid{get; init;}


        public string Id { get { return @"CCF_I22"; } }
        public string MessageStructureId { get { return @"CCF_I22"; } }
        public string EventDescription { get { return @"Collaborative Care Fetch / Collaborative Care Information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V271TriggerEventCCF_I22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.pid = new HL7V271SegmentPID(this.message);

        }
    }
}
