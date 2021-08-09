using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventVXX_V02
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentMSA msa{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentQRD qrd{get; init;}
public HL7V25SegmentQRF qrf{get; init;}


        public string Id { get { return @"VXX_V02"; } }
        public string MessageStructureId { get { return @"VXX_V02"; } }
        public string EventDescription { get { return @"Vaccination Record Query Returning Multiple PID Matches"; } }

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

        public HL7V25TriggerEventVXX_V02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qrd = new HL7V25SegmentQRD(this.message);
this.qrf = new HL7V25SegmentQRF(this.message);

        }
    }
}
