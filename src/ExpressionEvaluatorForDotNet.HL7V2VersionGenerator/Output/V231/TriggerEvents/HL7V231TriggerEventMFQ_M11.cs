using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventMFQ_M11
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentQRD qrd{ get; init; }
public HL7V231SegmentQRF qrf{ get; init; }
public HL7V231SegmentDSC dsc{ get; init; }


        public string Id { get { return @"MFQ_M11"; } }
        public string MessageStructureId { get { return @"MFQ_M11"; } }
        public string EventDescription { get { return @"Query for Master File Record - Test/calculated observations"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V231TriggerEventMFQ_M11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.qrd = new HL7V231SegmentQRD(this.message);
this.qrf = new HL7V231SegmentQRF(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
