using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventPPT_PCL
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentMSA msa;
public readonly HL7V251SegmentERR err;
public readonly HL7V251SegmentQAK qak;
public readonly HL7V251SegmentQRD qrd;


        public string Id { get { return @"PPT_PCL"; } }
        public string MessageStructureId { get { return @"PPT_PCL"; } }
        public string EventDescription { get { return @"Pathway (goal-oriented) query response"; } }

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

        public HL7V251TriggerEventPPT_PCL(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.qak = new HL7V251SegmentQAK(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);

        }
    }
}
