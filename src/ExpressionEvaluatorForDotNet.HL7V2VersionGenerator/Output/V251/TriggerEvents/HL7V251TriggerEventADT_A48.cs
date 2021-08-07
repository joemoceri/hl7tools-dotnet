using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A48
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentEVN evn;
public readonly HL7V251SegmentPID pid;
public readonly HL7V251SegmentPD1 pd1;
public readonly HL7V251SegmentMRG mrg;


        public string Id { get { return @"ADT_A48"; } }
        public string MessageStructureId { get { return @"ADT_A48"; } }
        public string EventDescription { get { return @"Change Alternate Patient ID"; } }

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

        public HL7V251TriggerEventADT_A48(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.mrg = new HL7V251SegmentMRG(this.message);

        }
    }
}
