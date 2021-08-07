using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventEDR_R07
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentMSA msa;
public readonly HL7V24SegmentERR err;
public readonly HL7V24SegmentQAK qak;
public readonly HL7V24SegmentDSP dsp;
public readonly HL7V24SegmentDSC dsc;


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
                        "CH_05",
                    };
            }
        }

        public HL7V24TriggerEventEDR_R07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.dsp = new HL7V24SegmentDSP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
