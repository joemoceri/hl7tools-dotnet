using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRDY_Z98
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentMSA msa;
public readonly HL7V251SegmentERR err;
public readonly HL7V251SegmentQAK qak;
public readonly HL7V251SegmentQPD qpd;
public readonly HL7V251SegmentDSP dsp;
public readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"RDY_Z98"; } }
        public string MessageStructureId { get { return @"RDY_Z98"; } }
        public string EventDescription { get { return @"Dispense History Response"; } }

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

        public HL7V251TriggerEventRDY_Z98(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.qak = new HL7V251SegmentQAK(this.message);
this.qpd = new HL7V251SegmentQPD(this.message);
this.dsp = new HL7V251SegmentDSP(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
