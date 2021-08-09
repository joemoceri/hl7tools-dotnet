using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRDY_Z98
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentMSA msa{get; init;}
public HL7V271SegmentERR err{get; init;}
public HL7V271SegmentQAK qak{get; init;}
public HL7V271SegmentQPD qpd{get; init;}
public HL7V271SegmentDSP dsp{get; init;}
public HL7V271SegmentDSC dsc{get; init;}


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

        public HL7V271TriggerEventRDY_Z98(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.qak = new HL7V271SegmentQAK(this.message);
this.qpd = new HL7V271SegmentQPD(this.message);
this.dsp = new HL7V271SegmentDSP(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
