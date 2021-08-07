using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRQI_I03
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentPID pid;
public readonly HL7V24SegmentNK1 nk1;
public readonly HL7V24SegmentNTE nte;


        public string Id { get { return @"RQI_I03"; } }
        public string MessageStructureId { get { return @"RQI_I03"; } }
        public string EventDescription { get { return @"Request/receipt of patient selection list"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
                    };
            }
        }

        public HL7V24TriggerEventRQI_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.nk1 = new HL7V24SegmentNK1(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
