using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRSP_K32
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentMSA msa;
private readonly HL7V271SegmentERR err;
private readonly HL7V271SegmentQAK qak;
private readonly HL7V271SegmentQPD qpd;
private readonly HL7V271SegmentDSC dsc;


        public string Id { get { return @"RSP_K32"; } }
        public string MessageStructureId { get { return @"RSP_K32"; } }
        public string EventDescription { get { return @"Find Candidates including Visit Information Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V271TriggerEventRSP_K32(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.qak = new HL7V271SegmentQAK(this.message);
this.qpd = new HL7V271SegmentQPD(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
