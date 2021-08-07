using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQBP_Q23
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentQPD qpd;
public readonly HL7V24SegmentRCP rcp;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"QBP_Q23"; } }
        public string MessageStructureId { get { return @"QBP_Q23"; } }
        public string EventDescription { get { return @"Query - Get Corresponding Identifiers"; } }

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

        public HL7V24TriggerEventQBP_Q23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qpd = new HL7V24SegmentQPD(this.message);
this.rcp = new HL7V24SegmentRCP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
