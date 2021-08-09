using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRER_RER
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentMSA msa{get; init;}
public HL7V251SegmentERR err{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentDSC dsc{get; init;}


        public string Id { get { return @"RER_RER"; } }
        public string MessageStructureId { get { return @"RER_RER"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Encoded Order Information Response"; } }

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

        public HL7V251TriggerEventRER_RER(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
