using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventMFN_M02
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentMFI mfi;


        public string Id { get { return @"MFN_M02"; } }
        public string MessageStructureId { get { return @"MFN_M02"; } }
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

        public HL7V22TriggerEventMFN_M02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.mfi = new HL7V22SegmentMFI(this.message);

        }
    }
}