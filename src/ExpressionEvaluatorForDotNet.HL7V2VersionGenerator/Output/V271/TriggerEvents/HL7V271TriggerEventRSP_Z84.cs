using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRSP_Z84
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentMSA msa{ get; init; }
public HL7V271SegmentERR err{ get; init; }
public HL7V271SegmentQAK qak{ get; init; }
public HL7V271SegmentQPD qpd{ get; init; }
public HL7V271SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RSP_Z84"; } }
        public string MessageStructureId { get { return @"RSP_Z84"; } }
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

        public HL7V271TriggerEventRSP_Z84(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.qak = new HL7V271SegmentQAK(this.message);
this.qpd = new HL7V271SegmentQPD(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
