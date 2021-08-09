using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventOPU_R25
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentNTE nte{get; init;}
public HL7V26SegmentPV1 pv1{get; init;}
public HL7V26SegmentPV2 pv2{get; init;}
public HL7V26SegmentOBX obx{get; init;}
public HL7V26SegmentNTE nte{get; init;}
public HL7V26SegmentROL rol{get; init;}


        public string Id { get { return @"OPU_R25"; } }
        public string MessageStructureId { get { return @"OPU_R25"; } }
        public string EventDescription { get { return @"Unsolicited Population/Location-Based Laboratory Observation "; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V26TriggerEventOPU_R25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.nte = new HL7V26SegmentNTE(this.message);
this.pv1 = new HL7V26SegmentPV1(this.message);
this.pv2 = new HL7V26SegmentPV2(this.message);
this.obx = new HL7V26SegmentOBX(this.message);
this.nte = new HL7V26SegmentNTE(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}
