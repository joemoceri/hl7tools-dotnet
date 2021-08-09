using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventMFK_M07
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentMSA msa{get; init;}
public HL7V28SegmentERR err{get; init;}
public HL7V28SegmentMFI mfi{get; init;}
public HL7V28SegmentMFA mfa{get; init;}


        public string Id { get { return @"MFK_M07"; } }
        public string MessageStructureId { get { return @"MFK_M07"; } }
        public string EventDescription { get { return @"Clinical Study without Phases but with Schedules Master File Application Acknowledgment"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V28TriggerEventMFK_M07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.mfi = new HL7V28SegmentMFI(this.message);
this.mfa = new HL7V28SegmentMFA(this.message);

        }
    }
}
