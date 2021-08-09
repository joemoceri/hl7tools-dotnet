using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRRD_O14
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentMSA msa{get; init;}
public HL7V27SegmentERR err{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentNTE nte{get; init;}


        public string Id { get { return @"RRD_O14"; } }
        public string MessageStructureId { get { return @"RRD_O14"; } }
        public string EventDescription { get { return @"Pharmacy/treatment dispense acknowledgment"; } }

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

        public HL7V27TriggerEventRRD_O14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
