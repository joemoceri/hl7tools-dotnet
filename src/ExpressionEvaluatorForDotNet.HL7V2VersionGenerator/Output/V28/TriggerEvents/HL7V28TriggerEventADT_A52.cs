using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventADT_A52
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentEVN evn{ get; init; }
public HL7V28SegmentPID pid{ get; init; }
public HL7V28SegmentPD1 pd1{ get; init; }
public HL7V28SegmentPV1 pv1{ get; init; }
public HL7V28SegmentPV2 pv2{ get; init; }


        public string Id { get { return @"ADT_A52"; } }
        public string MessageStructureId { get { return @"ADT_A52"; } }
        public string EventDescription { get { return @"Cancel leave of absence for a patient"; } }

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

        public HL7V28TriggerEventADT_A52(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.pd1 = new HL7V28SegmentPD1(this.message);
this.pv1 = new HL7V28SegmentPV1(this.message);
this.pv2 = new HL7V28SegmentPV2(this.message);

        }
    }
}
