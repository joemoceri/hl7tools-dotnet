using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventNMR_N02
    {
        private readonly HL7V2Message message;
        private readonly HL7V22SegmentMSH msh;
private readonly HL7V22SegmentMSA msa;
private readonly HL7V22SegmentERR err;
private readonly HL7V22SegmentQRD qrd;


        public string Id { get { return @"NMR_N02"; } }
        public string MessageStructureId { get { return @"NMR_N02"; } }
        public string EventDescription { get { return @"Network Management Response"; } }

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

        public HL7V22TriggerEventNMR_N02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.err = new HL7V22SegmentERR(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);

        }
    }
}
