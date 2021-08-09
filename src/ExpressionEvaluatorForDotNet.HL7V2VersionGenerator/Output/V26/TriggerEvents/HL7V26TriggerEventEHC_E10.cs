using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventEHC_E10
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentMSA msa{get; init;}
public HL7V26SegmentERR err{get; init;}


        public string Id { get { return @"EHC_E10"; } }
        public string MessageStructureId { get { return @"EHC_E10"; } }
        public string EventDescription { get { return @"Edit/Adjudication Results"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

                    };
            }
        }

        public HL7V26TriggerEventEHC_E10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);

        }
    }
}
