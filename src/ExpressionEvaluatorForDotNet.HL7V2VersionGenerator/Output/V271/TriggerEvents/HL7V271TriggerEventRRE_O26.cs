using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRRE_O26
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentMSA msa;
public readonly HL7V271SegmentERR err;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentNTE nte;


        public string Id { get { return @"RRE_O26"; } }
        public string MessageStructureId { get { return @"RRE_O26"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Refill Authorization Acknowledgement"; } }

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

        public HL7V271TriggerEventRRE_O26(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}