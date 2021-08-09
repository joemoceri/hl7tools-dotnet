using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventQBP_Q21
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentQPD qpd{get; init;}
public HL7V24SegmentRCP rcp{get; init;}
public HL7V24SegmentDSC dsc{get; init;}


        public string Id { get { return @"QBP_Q21"; } }
        public string MessageStructureId { get { return @"QBP_Q21"; } }
        public string EventDescription { get { return @"Query - Get Person Demographics"; } }

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

        public HL7V24TriggerEventQBP_Q21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.qpd = new HL7V24SegmentQPD(this.message);
this.rcp = new HL7V24SegmentRCP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
