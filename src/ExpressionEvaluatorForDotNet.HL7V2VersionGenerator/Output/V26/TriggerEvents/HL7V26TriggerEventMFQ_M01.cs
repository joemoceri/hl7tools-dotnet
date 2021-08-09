using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventMFQ_M01
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentQRD qrd{get; init;}
public HL7V26SegmentQRF qrf{get; init;}
public HL7V26SegmentDSC dsc{get; init;}


        public string Id { get { return @"MFQ_M01"; } }
        public string MessageStructureId { get { return @"MFQ_M01"; } }
        public string EventDescription { get { return @"Query for master file record"; } }

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

        public HL7V26TriggerEventMFQ_M01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
