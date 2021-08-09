using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventDOC_T12
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentMSA msa{ get; init; }
public HL7V25SegmentERR err{ get; init; }
public HL7V25SegmentQAK qak{ get; init; }
public HL7V25SegmentQRD qrd{ get; init; }
public HL7V25SegmentDSC dsc{ get; init; }


        public string Id { get { return @"DOC_T12"; } }
        public string MessageStructureId { get { return @"DOC_T12"; } }
        public string EventDescription { get { return @"Document response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V25TriggerEventDOC_T12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
