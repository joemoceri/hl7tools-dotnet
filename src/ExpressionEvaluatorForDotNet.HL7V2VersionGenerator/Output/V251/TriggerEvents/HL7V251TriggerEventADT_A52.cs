using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A52
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentEVN evn{ get; init; }
public HL7V251SegmentPID pid{ get; init; }
public HL7V251SegmentPD1 pd1{ get; init; }
public HL7V251SegmentPV1 pv1{ get; init; }
public HL7V251SegmentPV2 pv2{ get; init; }


        public string Id { get { return @"ADT_A52"; } }
        public string MessageStructureId { get { return @"ADT_A52"; } }
        public string EventDescription { get { return @"Cancel Leave of Absence for a Patient"; } }

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

        public HL7V251TriggerEventADT_A52(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.pv2 = new HL7V251SegmentPV2(this.message);

        }
    }
}
