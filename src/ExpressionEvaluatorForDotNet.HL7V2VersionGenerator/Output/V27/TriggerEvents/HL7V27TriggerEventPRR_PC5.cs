using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventPRR_PC5
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentMSA msa;
private readonly HL7V27SegmentERR err;
private readonly HL7V27SegmentQAK qak;
private readonly HL7V27SegmentQRD qrd;


        public string Id { get { return @"PRR_PC5"; } }
        public string MessageStructureId { get { return @"PRR_PC5"; } }
        public string EventDescription { get { return @"PC/ problem response"; } }

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

        public HL7V27TriggerEventPRR_PC5(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.qak = new HL7V27SegmentQAK(this.message);
this.qrd = new HL7V27SegmentQRD(this.message);

        }
    }
}
