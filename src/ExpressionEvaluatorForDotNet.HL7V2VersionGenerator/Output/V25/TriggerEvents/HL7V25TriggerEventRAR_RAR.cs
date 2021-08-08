using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRAR_RAR
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentMSA msa;
private readonly HL7V25SegmentERR err;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"RAR_RAR"; } }
        public string MessageStructureId { get { return @"RAR_RAR"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Administration Information Response"; } }

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

        public HL7V25TriggerEventRAR_RAR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
