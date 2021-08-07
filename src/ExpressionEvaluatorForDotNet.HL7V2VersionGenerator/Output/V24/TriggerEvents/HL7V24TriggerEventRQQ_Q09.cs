using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRQQ_Q09
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentERQ erq;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"RQQ_Q09"; } }
        public string MessageStructureId { get { return @"RQQ_Q09"; } }
        public string EventDescription { get { return @"Event replay query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V24TriggerEventRQQ_Q09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.erq = new HL7V24SegmentERQ(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
