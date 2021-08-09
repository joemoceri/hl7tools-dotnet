using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventADT_A35
    {
        public HL7V2Message message { get; init; }
        public HL7V22SegmentMSH msh{ get; init; }
public HL7V22SegmentEVN evn{ get; init; }
public HL7V22SegmentPID pid{ get; init; }
public HL7V22SegmentMRG mrg{ get; init; }


        public string Id { get { return @"ADT_A35"; } }
        public string MessageStructureId { get { return @"ADT_A35"; } }
        public string EventDescription { get { return @"account number only"; } }

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

        public HL7V22TriggerEventADT_A35(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.mrg = new HL7V22SegmentMRG(this.message);

        }
    }
}
