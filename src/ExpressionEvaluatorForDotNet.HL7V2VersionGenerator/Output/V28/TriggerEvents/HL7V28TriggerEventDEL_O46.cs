using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventDEL_O46
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSTF stf;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentDON don;
public readonly HL7V28SegmentNTE nte;


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
