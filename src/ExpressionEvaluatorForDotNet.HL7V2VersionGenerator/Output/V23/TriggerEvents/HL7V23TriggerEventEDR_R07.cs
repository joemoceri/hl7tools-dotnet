using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventEDR_R07
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentMSA msa;
private readonly HL7V23SegmentERR err;
private readonly HL7V23SegmentQAK qak;
private readonly HL7V23SegmentDSP dsp;
private readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"EDR_R07"; } }
        public string MessageStructureId { get { return @"EDR_R07"; } }
        public string EventDescription { get { return @"Enhanced display response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V23TriggerEventEDR_R07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.qak = new HL7V23SegmentQAK(this.message);
this.dsp = new HL7V23SegmentDSP(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
