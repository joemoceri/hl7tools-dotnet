using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventPMU_B06
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEVN evn{get; init;}
public HL7V25SegmentSTF stf{get; init;}
public HL7V25SegmentPRA pra{get; init;}
public HL7V25SegmentORG org{get; init;}


        public string Id { get { return @"PMU_B06"; } }
        public string MessageStructureId { get { return @"PMU_B06"; } }
        public string EventDescription { get { return @"Terminate Practicing Person"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V25TriggerEventPMU_B06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.stf = new HL7V25SegmentSTF(this.message);
this.pra = new HL7V25SegmentPRA(this.message);
this.org = new HL7V25SegmentORG(this.message);

        }
    }
}
