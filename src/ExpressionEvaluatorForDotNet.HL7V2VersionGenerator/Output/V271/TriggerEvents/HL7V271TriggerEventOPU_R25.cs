using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventOPU_R25
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentNTE nte{get; init;}
public HL7V271SegmentPV1 pv1{get; init;}
public HL7V271SegmentPV2 pv2{get; init;}
public HL7V271SegmentPRT prt{get; init;}


        public string Id { get { return @"OPU_R25"; } }
        public string MessageStructureId { get { return @"OPU_R25"; } }
        public string EventDescription { get { return @"Unsolicited Population/Location-Based Laboratory Observation Message"; } }

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

        public HL7V271TriggerEventOPU_R25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.nte = new HL7V271SegmentNTE(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.pv2 = new HL7V271SegmentPV2(this.message);
this.prt = new HL7V271SegmentPRT(this.message);

        }
    }
}
