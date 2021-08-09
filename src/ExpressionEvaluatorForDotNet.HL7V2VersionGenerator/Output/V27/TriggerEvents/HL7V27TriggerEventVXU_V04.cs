using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventVXU_V04
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentPID pid{ get; init; }
public HL7V27SegmentPD1 pd1{ get; init; }
public HL7V27SegmentNK1 nk1{ get; init; }
public HL7V27SegmentGT1 gt1{ get; init; }


        public string Id { get { return @"VXU_V04"; } }
        public string MessageStructureId { get { return @"VXU_V04"; } }
        public string EventDescription { get { return @"Unsolicited vaccination record update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V27TriggerEventVXU_V04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.gt1 = new HL7V27SegmentGT1(this.message);

        }
    }
}
