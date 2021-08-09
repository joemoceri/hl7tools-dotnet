using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventVXQ_V01
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentQRD qrd{get; init;}
public HL7V24SegmentQRF qrf{get; init;}


        public string Id { get { return @"VXQ_V01"; } }
        public string MessageStructureId { get { return @"VXQ_V01"; } }
        public string EventDescription { get { return @"Query for vaccination record"; } }

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

        public HL7V24TriggerEventVXQ_V01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);

        }
    }
}
