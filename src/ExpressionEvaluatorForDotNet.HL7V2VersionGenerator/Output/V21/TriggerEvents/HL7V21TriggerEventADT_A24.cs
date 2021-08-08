using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventADT_A24
    {
        private readonly HL7V2Message message;
        private readonly HL7V21SegmentMSH msh;
private readonly HL7V21SegmentEVN evn;
private readonly HL7V21SegmentPID pid;
private readonly HL7V21SegmentPV1 pv1;
private readonly HL7V21SegmentPID pid;


        public string Id { get { return @"ADT_A24"; } }
        public string MessageStructureId { get { return @"ADT_A24"; } }
        public string EventDescription { get { return @"Create a Patient Link Transaction"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventADT_A24(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.evn = new HL7V21SegmentEVN(this.message);
this.pid = new HL7V21SegmentPID(this.message);
this.pv1 = new HL7V21SegmentPV1(this.message);
this.pid = new HL7V21SegmentPID(this.message);

        }
    }
}
