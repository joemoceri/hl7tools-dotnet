using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventNMR_N01
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentERR err;
public readonly HL7V23SegmentQRD qrd;


        public string Id { get { return @"NMR_N01"; } }
        public string MessageStructureId { get { return @"NMR_N01"; } }
        public string EventDescription { get { return @"Network management response message"; } }

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

        public HL7V23TriggerEventNMR_N01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.err = new HL7V23SegmentERR(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);

        }
    }
}
