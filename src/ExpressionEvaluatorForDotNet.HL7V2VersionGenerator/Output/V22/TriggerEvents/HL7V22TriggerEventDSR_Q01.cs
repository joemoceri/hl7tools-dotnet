using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventDSR_Q01
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentMFA mfa;
public readonly HL7V22SegmentERR err;
public readonly HL7V22SegmentQRD qrd;
public readonly HL7V22SegmentQRF qrf;
public readonly HL7V22SegmentDSP dsp;
public readonly HL7V22SegmentDSC dsc;


        public string Id { get { return @"DSR_Q01"; } }
        public string MessageStructureId { get { return @"DSR_Q01"; } }
        public string EventDescription { get { return @"Display Response Message"; } }

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

        public HL7V22TriggerEventDSR_Q01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.mfa = new HL7V22SegmentMFA(this.message);
this.err = new HL7V22SegmentERR(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);
this.qrf = new HL7V22SegmentQRF(this.message);
this.dsp = new HL7V22SegmentDSP(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
