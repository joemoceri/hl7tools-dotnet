using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventEDR_R07
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;
public readonly HL7V25SegmentQAK qak;
public readonly HL7V25SegmentDSP dsp;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"EDR_R07"; } }
        public string MessageStructureId { get { return @"EDR_R07"; } }
        public string EventDescription { get { return @"Enhanced Display Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V25TriggerEventEDR_R07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.dsp = new HL7V25SegmentDSP(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
