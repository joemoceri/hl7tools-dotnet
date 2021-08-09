using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventSDR_S31
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentSDD sdd{get; init;}


        public string Id { get { return @"SDR_S31"; } }
        public string MessageStructureId { get { return @"SDR_S31"; } }
        public string EventDescription { get { return @"Request anti-microbial device data"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V27TriggerEventSDR_S31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.sdd = new HL7V27SegmentSDD(this.message);

        }
    }
}
