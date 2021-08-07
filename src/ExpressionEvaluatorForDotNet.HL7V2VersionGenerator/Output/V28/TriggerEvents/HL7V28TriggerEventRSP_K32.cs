using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRSP_K32
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentMSA msa;
public readonly HL7V28SegmentERR err;
public readonly HL7V28SegmentQAK qak;
public readonly HL7V28SegmentQPD qpd;
public readonly HL7V28SegmentDSC dsc;


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

        public HL7V28TriggerEventRSP_K32(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.qak = new HL7V28SegmentQAK(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
