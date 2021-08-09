using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventDOC_T12
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentMSA msa{ get; init; }
public HL7V231SegmentERR err{ get; init; }
public HL7V231SegmentQAK qak{ get; init; }
public HL7V231SegmentQRD qrd{ get; init; }
public HL7V231SegmentDSC dsc{ get; init; }


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

        public HL7V231TriggerEventDOC_T12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.qak = new HL7V231SegmentQAK(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
