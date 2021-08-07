using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventADT_A18
    {
        public readonly HL7V2Message message;
        public readonly HL7V22SegmentMSH msh;
public readonly HL7V22SegmentEVN evn;
public readonly HL7V22SegmentPID pid;
public readonly HL7V22SegmentMRG mrg;
public readonly HL7V22SegmentPV1 pv1;


        public string Id { get { return @"ADT_A18"; } }
        public string MessageStructureId { get { return @"ADT_A18"; } }
        public string EventDescription { get { return @"Merge Patient Information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
                    };
            }
        }

        public HL7V22TriggerEventADT_A18(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.mrg = new HL7V22SegmentMRG(this.message);
this.pv1 = new HL7V22SegmentPV1(this.message);

        }
    }
}
