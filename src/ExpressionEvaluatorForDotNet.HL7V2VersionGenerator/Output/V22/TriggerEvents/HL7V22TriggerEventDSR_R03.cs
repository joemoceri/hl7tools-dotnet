using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventDSR_R03
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentMSA msa{get; init;}
public HL7V22SegmentQRD qrd{get; init;}
public HL7V22SegmentQRF qrf{get; init;}
public HL7V22SegmentDSP dsp{get; init;}
public HL7V22SegmentDSC dsc{get; init;}


        public string Id { get { return @"DSR_R03"; } }
        public string MessageStructureId { get { return @"DSR_R03"; } }
        public string EventDescription { get { return @"oriented results, query/unsol. update"; } }

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

        public HL7V22TriggerEventDSR_R03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);
this.qrf = new HL7V22SegmentQRF(this.message);
this.dsp = new HL7V22SegmentDSP(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
