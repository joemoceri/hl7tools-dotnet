using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventNMR_N01
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentMSA msa;
private readonly HL7V25SegmentERR err;
private readonly HL7V25SegmentQRD qrd;


        public string Id { get { return @"NMR_N01"; } }
        public string MessageStructureId { get { return @"NMR_N01"; } }
        public string EventDescription { get { return @"Application management response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

                    };
            }
        }

        public HL7V25TriggerEventNMR_N01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);

        }
    }
}
