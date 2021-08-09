using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventADT_A60
    {
        public HL7V2Message message { get; init; }
        public HL7V26SegmentMSH msh{ get; init; }
public HL7V26SegmentSFT sft{ get; init; }
public HL7V26SegmentUAC uac{ get; init; }
public HL7V26SegmentEVN evn{ get; init; }
public HL7V26SegmentPID pid{ get; init; }
public HL7V26SegmentARV arv{ get; init; }
public HL7V26SegmentPV1 pv1{ get; init; }
public HL7V26SegmentPV2 pv2{ get; init; }
public HL7V26SegmentARV arv{ get; init; }
public HL7V26SegmentIAM iam{ get; init; }


        public string Id { get { return @"ADT_A60"; } }
        public string MessageStructureId { get { return @"ADT_A60"; } }
        public string EventDescription { get { return @"Update Adverse Reaction Information "; } }

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

        public HL7V26TriggerEventADT_A60(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.evn = new HL7V26SegmentEVN(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.arv = new HL7V26SegmentARV(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.pv2 = new HL7V26SegmentPV2(this.message);
this.arv = new HL7V26SegmentARV(this.message);
this.iam = new HL7V26SegmentIAM(this.message);

        }
    }
}
