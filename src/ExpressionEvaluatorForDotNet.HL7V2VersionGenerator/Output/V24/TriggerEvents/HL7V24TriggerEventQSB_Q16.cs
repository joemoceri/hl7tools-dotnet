using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQSB_Q16
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentQPD qpd;
public readonly HL7V24SegmentRCP rcp;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"QSB_Q16"; } }
        public string MessageStructureId { get { return @"QSB_Q16"; } }
        public string EventDescription { get { return @"Create subscription"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
                    };
            }
        }

        public HL7V24TriggerEventQSB_Q16(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qpd = new HL7V24SegmentQPD(this.message);
this.rcp = new HL7V24SegmentRCP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
