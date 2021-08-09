using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventDEL_O46
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSTF stf{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentDON don{get; init;}
public HL7V28SegmentNTE nte{get; init;}


        public string Id { get { return @"DEL_O46"; } }
        public string MessageStructureId { get { return @"DEL_O46"; } }
        public string EventDescription { get { return @"Donor Eligibility"; } }

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

        public HL7V28TriggerEventDEL_O46(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.stf = new HL7V28SegmentSTF(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.don = new HL7V28SegmentDON(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
