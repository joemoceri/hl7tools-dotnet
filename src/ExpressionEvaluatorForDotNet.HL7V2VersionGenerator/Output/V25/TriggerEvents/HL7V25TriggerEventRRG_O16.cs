using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRRG_O16
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentMSA msa{get; init;}
public HL7V25SegmentERR err{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentNTE nte{get; init;}


        public string Id { get { return @"RRG_O16"; } }
        public string MessageStructureId { get { return @"RRG_O16"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Give Acknowledgement"; } }

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

        public HL7V25TriggerEventRRG_O16(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
