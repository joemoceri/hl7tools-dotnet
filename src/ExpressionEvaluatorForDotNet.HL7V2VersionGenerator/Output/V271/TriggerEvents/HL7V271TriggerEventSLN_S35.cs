using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSLN_S35
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentSLT slt{get; init;}


        public string Id { get { return @"SLN_S35"; } }
        public string MessageStructureId { get { return @"SLN_S35"; } }
        public string EventDescription { get { return @"Notification of sterilization lot deletion"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V271TriggerEventSLN_S35(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.slt = new HL7V271SegmentSLT(this.message);

        }
    }
}
