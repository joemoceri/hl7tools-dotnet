using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventSQR_S25
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;
public readonly HL7V25SegmentQAK qak;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"SQR_S25"; } }
        public string MessageStructureId { get { return @"SQR_S25"; } }
        public string EventDescription { get { return @"Schedule query message and response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
                    };
            }
        }

        public HL7V25TriggerEventSQR_S25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
