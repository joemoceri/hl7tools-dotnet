using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRTB_Z92
    {
        public readonly HL7V2Message message;
        public readonly HL7V27SegmentMSH msh;
public readonly HL7V27SegmentSFT sft;
public readonly HL7V27SegmentUAC uac;
public readonly HL7V27SegmentMSA msa;
public readonly HL7V27SegmentERR err;
public readonly HL7V27SegmentQAK qak;
public readonly HL7V27SegmentQPD qpd;
public readonly HL7V27SegmentDSC dsc;


        public string Id { get { return @"RTB_Z92"; } }
        public string MessageStructureId { get { return @"RTB_Z92"; } }
        public string EventDescription { get { return @"Who Am I (Response)"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V27TriggerEventRTB_Z92(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.qak = new HL7V27SegmentQAK(this.message);
this.qpd = new HL7V27SegmentQPD(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
