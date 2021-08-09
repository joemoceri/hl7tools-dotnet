using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventOPR_O38
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentMSA msa{get; init;}
public HL7V271SegmentERR err{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentNTE nte{get; init;}


        public string Id { get { return @"OPR_O38"; } }
        public string MessageStructureId { get { return @"OPR_O38"; } }
        public string EventDescription { get { return @"Population/Location-Based Laboratory Order Acknowledgment Message"; } }

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

        public HL7V271TriggerEventOPR_O38(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
