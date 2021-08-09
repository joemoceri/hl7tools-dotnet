using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventDFT_P03
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentEVN evn{ get; init; }
public HL7V231SegmentPID pid{ get; init; }
public HL7V231SegmentPD1 pd1{ get; init; }
public HL7V231SegmentPV1 pv1{ get; init; }
public HL7V231SegmentPV2 pv2{ get; init; }
public HL7V231SegmentDB1 db1{ get; init; }
public HL7V231SegmentOBX obx{ get; init; }
public HL7V231SegmentDG1 dg1{ get; init; }
public HL7V231SegmentDRG drg{ get; init; }
public HL7V231SegmentGT1 gt1{ get; init; }
public HL7V231SegmentACC acc{ get; init; }


        public string Id { get { return @"DFT_P03"; } }
        public string MessageStructureId { get { return @"DFT_P03"; } }
        public string EventDescription { get { return @"Post detail financial transaction"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V231TriggerEventDFT_P03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);
this.pv2 = new HL7V231SegmentPV2(this.message);
this.db1 = new HL7V231SegmentDB1(this.message);
this.obx = new HL7V231SegmentOBX(this.message);
this.dg1 = new HL7V231SegmentDG1(this.message);
this.drg = new HL7V231SegmentDRG(this.message);
this.gt1 = new HL7V231SegmentGT1(this.message);
this.acc = new HL7V231SegmentACC(this.message);

        }
    }
}
