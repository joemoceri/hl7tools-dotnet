using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventORF_R04
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentQRD qrd;
public readonly HL7V26SegmentQRF qrf;
public readonly HL7V26SegmentERR err;
public readonly HL7V26SegmentQAK qak;
public readonly HL7V26SegmentDSC dsc;


        public string Id { get { return @"ORF_R04"; } }
        public string MessageStructureId { get { return @"ORF_R04"; } }
        public string EventDescription { get { return @"Results of Observation Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
                    };
            }
        }

        public HL7V26TriggerEventORF_R04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
