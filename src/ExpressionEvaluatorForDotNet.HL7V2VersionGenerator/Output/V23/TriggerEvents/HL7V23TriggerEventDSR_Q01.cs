using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventDSR_Q01
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentMSA msa{get; init;}
public HL7V23SegmentERR err{get; init;}
public HL7V23SegmentQAK qak{get; init;}
public HL7V23SegmentQRD qrd{get; init;}
public HL7V23SegmentQRF qrf{get; init;}
public HL7V23SegmentDSP dsp{get; init;}
public HL7V23SegmentDSC dsc{get; init;}


        public string Id { get { return @"DSR_Q01"; } }
        public string MessageStructureId { get { return @"DSR_Q01"; } }
        public string EventDescription { get { return @"Display response message"; } }

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

        public HL7V23TriggerEventDSR_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.qak = new HL7V23SegmentQAK(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.dsp = new HL7V23SegmentDSP(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
