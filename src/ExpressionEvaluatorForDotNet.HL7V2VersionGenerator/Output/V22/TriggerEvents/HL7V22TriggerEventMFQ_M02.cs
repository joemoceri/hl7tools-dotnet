using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventMFQ_M02
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentQRD qrd{ get; init; }
public HL7V22SegmentQRF qrf{ get; init; }
public HL7V22SegmentDSC dsc{ get; init; }


        public string Id { get { return @"MFQ_M02"; } }
        public string MessageStructureId { get { return @"MFQ_M02"; } }
        public string EventDescription { get { return @"Staff Practitioneer"; } }

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

        public HL7V22TriggerEventMFQ_M02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);
this.qrf = new HL7V22SegmentQRF(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
