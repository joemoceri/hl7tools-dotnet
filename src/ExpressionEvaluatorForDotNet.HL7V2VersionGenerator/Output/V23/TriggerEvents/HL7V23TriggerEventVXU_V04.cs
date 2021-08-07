using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventVXU_V04
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentPID pid;
public readonly HL7V23SegmentPD1 pd1;
public readonly HL7V23SegmentNK1 nk1;


        public string Id { get { return @"VXU_V04"; } }
        public string MessageStructureId { get { return @"VXU_V04"; } }
        public string EventDescription { get { return @"Unsolicited vaccination record update"; } }

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

        public HL7V23TriggerEventVXU_V04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.pd1 = new HL7V23SegmentPD1(this.message);
this.nk1 = new HL7V23SegmentNK1(this.message);

        }
    }
}
