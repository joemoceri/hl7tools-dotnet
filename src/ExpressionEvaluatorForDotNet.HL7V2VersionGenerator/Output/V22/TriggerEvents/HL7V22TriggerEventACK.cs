using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventACK
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentMSA msa;
public readonly HL7V22SegmentERR err;


        public string Id { get { return @"ACK"; } }
        public string MessageStructureId { get { return @"ACK"; } }
        public string EventDescription { get { return @"General acknowledgement"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            }
        }

        public HL7V22TriggerEventACK(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.err = new HL7V22SegmentERR(this.message);

        }
    }
}
