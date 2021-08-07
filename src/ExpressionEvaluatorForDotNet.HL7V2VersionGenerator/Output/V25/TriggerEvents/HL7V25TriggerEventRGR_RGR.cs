using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRGR_RGR
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"RGR_RGR"; } }
        public string MessageStructureId { get { return @"RGR_RGR"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Dose Information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            }
        }

        public HL7V25TriggerEventRGR_RGR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
