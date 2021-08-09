using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventADT_A53
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentEVN evn{ get; init; }
public HL7V271SegmentPID pid{ get; init; }
public HL7V271SegmentPD1 pd1{ get; init; }
public HL7V271SegmentPV1 pv1{ get; init; }
public HL7V271SegmentPV2 pv2{ get; init; }


        public string Id { get { return @"ADT_A53"; } }
        public string MessageStructureId { get { return @"ADT_A53"; } }
        public string EventDescription { get { return @"Cancel patient returns from a leave of absence"; } }

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

        public HL7V271TriggerEventADT_A53(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.pv2 = new HL7V271SegmentPV2(this.message);

        }
    }
}
