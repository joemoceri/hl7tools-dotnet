using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventPTR_PCF
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentERR err;
public readonly HL7V23SegmentQRD qrd;


        public string Id { get { return @"PTR_PCF"; } }
        public string MessageStructureId { get { return @"PTR_PCF"; } }
        public string EventDescription { get { return @"Pathway (problem-oriented) query response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
                    };
            }
        }

        public HL7V23TriggerEventPTR_PCF(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);

        }
    }
}
