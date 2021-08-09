using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventPEX_P07
    {
        public HL7V2Message message { get; init; }
        public HL7V231SegmentMSH msh{ get; init; }
public HL7V231SegmentEVN evn{ get; init; }
public HL7V231SegmentPID pid{ get; init; }
public HL7V231SegmentPD1 pd1{ get; init; }
public HL7V231SegmentNTE nte{ get; init; }


        public string Id { get { return @"PEX_P07"; } }
        public string MessageStructureId { get { return @"PEX_P07"; } }
        public string EventDescription { get { return @"Unsolicited initial individual product experience report"; } }

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

        public HL7V231TriggerEventPEX_P07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
