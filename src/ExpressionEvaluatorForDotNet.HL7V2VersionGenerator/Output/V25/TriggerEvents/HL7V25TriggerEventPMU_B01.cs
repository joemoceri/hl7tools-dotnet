using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventPMU_B01
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentEVN evn{ get; init; }
public HL7V25SegmentSTF stf{ get; init; }
public HL7V25SegmentPRA pra{ get; init; }
public HL7V25SegmentORG org{ get; init; }
public HL7V25SegmentAFF aff{ get; init; }
public HL7V25SegmentLAN lan{ get; init; }
public HL7V25SegmentEDU edu{ get; init; }
public HL7V25SegmentCER cer{ get; init; }


        public string Id { get { return @"PMU_B01"; } }
        public string MessageStructureId { get { return @"PMU_B01"; } }
        public string EventDescription { get { return @"Add personnel record"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V25TriggerEventPMU_B01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.stf = new HL7V25SegmentSTF(this.message);
this.pra = new HL7V25SegmentPRA(this.message);
this.org = new HL7V25SegmentORG(this.message);
this.aff = new HL7V25SegmentAFF(this.message);
this.lan = new HL7V25SegmentLAN(this.message);
this.edu = new HL7V25SegmentEDU(this.message);
this.cer = new HL7V25SegmentCER(this.message);

        }
    }
}
