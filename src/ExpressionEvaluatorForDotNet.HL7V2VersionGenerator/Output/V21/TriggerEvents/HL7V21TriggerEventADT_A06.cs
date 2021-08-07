using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventADT_A06
    {
        public readonly HL7V2Message message;
        public readonly HL7V21SegmentMSH msh;
public readonly HL7V21SegmentEVN evn;
public readonly HL7V21SegmentPID pid;
public readonly HL7V21SegmentPV1 pv1;


        public string Id { get { return @"ADT_A06"; } }
        public string MessageStructureId { get { return @"ADT_A06"; } }
        public string EventDescription { get { return @"Transfer an Outpatient to Inpatient"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventADT_A06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.evn = new HL7V21SegmentEVN(this.message);
this.pid = new HL7V21SegmentPID(this.message);
this.pv1 = new HL7V21SegmentPV1(this.message);

        }
    }
}
