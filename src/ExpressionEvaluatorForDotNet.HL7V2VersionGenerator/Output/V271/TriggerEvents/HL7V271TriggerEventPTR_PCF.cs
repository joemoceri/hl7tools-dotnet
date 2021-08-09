using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventPTR_PCF
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentMSA msa{ get; init; }
public HL7V271SegmentERR err{ get; init; }
public HL7V271SegmentQAK qak{ get; init; }
public HL7V271SegmentQRD qrd{ get; init; }


        public string Id { get { return @"PTR_PCF"; } }
        public string MessageStructureId { get { return @"PTR_PCF"; } }
        public string EventDescription { get { return @"PC/ pathway (problem-oriented) query response"; } }

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

        public HL7V271TriggerEventPTR_PCF(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.qak = new HL7V271SegmentQAK(this.message);
this.qrd = new HL7V271SegmentQRD(this.message);

        }
    }
}
