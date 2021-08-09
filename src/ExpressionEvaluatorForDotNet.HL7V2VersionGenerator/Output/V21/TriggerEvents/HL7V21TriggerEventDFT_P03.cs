using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21TriggerEventDFT_P03
    {
        public HL7V2Message message { get; init; }
        public HL7V21SegmentMSH msh{ get; init; }
public HL7V21SegmentEVN evn{ get; init; }
public HL7V21SegmentPID pid{ get; init; }
public HL7V21SegmentPV1 pv1{ get; init; }
public HL7V21SegmentFT1 ft1{ get; init; }


        public string Id { get { return @"DFT_P03"; } }
        public string MessageStructureId { get { return @"DFT_P03"; } }
        public string EventDescription { get { return @"Post Detail Financial Transactions"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21TriggerEventDFT_P03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V21SegmentMSH(this.message);
this.evn = new HL7V21SegmentEVN(this.message);
this.pid = new HL7V21SegmentPID(this.message);
this.pv1 = new HL7V21SegmentPV1(this.message);
this.ft1 = new HL7V21SegmentFT1(this.message);

        }
    }
}
