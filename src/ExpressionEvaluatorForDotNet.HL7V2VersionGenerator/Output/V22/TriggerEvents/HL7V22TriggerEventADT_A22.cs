using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventADT_A22
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentEVN evn{ get; init; }
public HL7V22SegmentPID pid{ get; init; }
public HL7V22SegmentPV1 pv1{ get; init; }
public HL7V22SegmentPV2 pv2{ get; init; }
public HL7V22SegmentOBX obx{ get; init; }


        public string Id { get { return @"ADT_A22"; } }
        public string MessageStructureId { get { return @"ADT_A22"; } }
        public string EventDescription { get { return @"A Patient Returns From A ""Leave Of Absence"""; } }

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

        public HL7V22TriggerEventADT_A22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.pv1 = new HL7V22SegmentPV1(this.message);
this.pv2 = new HL7V22SegmentPV2(this.message);
this.obx = new HL7V22SegmentOBX(this.message);

        }
    }
}
