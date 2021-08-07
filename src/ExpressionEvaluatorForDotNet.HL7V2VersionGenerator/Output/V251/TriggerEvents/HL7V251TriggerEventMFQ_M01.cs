using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMFQ_M01
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentQRD qrd;
public readonly HL7V251SegmentQRF qrf;
public readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"MFQ_M01"; } }
        public string MessageStructureId { get { return @"MFQ_M01"; } }
        public string EventDescription { get { return @"Query for master file record"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
                    };
            }
        }

        public HL7V251TriggerEventMFQ_M01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
