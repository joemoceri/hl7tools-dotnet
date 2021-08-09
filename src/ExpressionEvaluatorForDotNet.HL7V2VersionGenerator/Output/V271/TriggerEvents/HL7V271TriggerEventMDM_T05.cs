using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventMDM_T05
    {
        public HL7V2Message message { get; init; }
        public HL7V271SegmentMSH msh{ get; init; }
public HL7V271SegmentSFT sft{ get; init; }
public HL7V271SegmentUAC uac{ get; init; }
public HL7V271SegmentEVN evn{ get; init; }
public HL7V271SegmentPID pid{ get; init; }
public HL7V271SegmentPV1 pv1{ get; init; }
public HL7V271SegmentTXA txa{ get; init; }
public HL7V271SegmentCON con{ get; init; }


        public string Id { get { return @"MDM_T05"; } }
        public string MessageStructureId { get { return @"MDM_T05"; } }
        public string EventDescription { get { return @"Document addendum notification"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V271TriggerEventMDM_T05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.txa = new HL7V271SegmentTXA(this.message);
this.con = new HL7V271SegmentCON(this.message);

        }
    }
}
