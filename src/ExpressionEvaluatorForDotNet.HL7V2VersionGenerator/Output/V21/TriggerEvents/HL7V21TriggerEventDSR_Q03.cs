using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventDSR_Q03
    {
        private readonly HL7V2Message message;
        public HL7V21SegmentMSH msh{get; init;}
public HL7V21SegmentQRD qrd{get; init;}
public HL7V21SegmentQRF qrf{get; init;}
public HL7V21SegmentDSP dsp{get; init;}
public HL7V21SegmentDSC dsc{get; init;}


        public string Id { get { return @"DSR_Q03"; } }
        public string MessageStructureId { get { return @"DSR_Q03"; } }
        public string EventDescription { get { return @"Deferred Response to A Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventDSR_Q03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.qrd = new HL7V21SegmentQRD(this.message);
this.qrf = new HL7V21SegmentQRF(this.message);
this.dsp = new HL7V21SegmentDSP(this.message);
this.dsc = new HL7V21SegmentDSC(this.message);

        }
    }
}
