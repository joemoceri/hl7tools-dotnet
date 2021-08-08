using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRDY_Z98
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentMSA msa;
private readonly HL7V28SegmentERR err;
private readonly HL7V28SegmentQAK qak;
private readonly HL7V28SegmentQPD qpd;
private readonly HL7V28SegmentDSP dsp;
private readonly HL7V28SegmentDSC dsc;


        public string Id { get { return @"RDY_Z98"; } }
        public string MessageStructureId { get { return @"RDY_Z98"; } }
        public string EventDescription { get { return @"Dispense History (Response)"; } }

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

        public HL7V28TriggerEventRDY_Z98(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.qak = new HL7V28SegmentQAK(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);
this.dsp = new HL7V28SegmentDSP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
