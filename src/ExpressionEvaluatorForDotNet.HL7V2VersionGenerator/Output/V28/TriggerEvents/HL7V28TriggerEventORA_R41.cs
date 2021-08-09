using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventORA_R41
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentMSA msa{get; init;}
public HL7V28SegmentERR err{get; init;}
public HL7V28SegmentPRT prt{get; init;}


        public string Id { get { return @"ORA_R41"; } }
        public string MessageStructureId { get { return @"ORA_R41"; } }
        public string EventDescription { get { return @"Observation Report Alert Acknowledgement"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V28TriggerEventORA_R41(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.prt = new HL7V28SegmentPRT(this.message);

        }
    }
}
