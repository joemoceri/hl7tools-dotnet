using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRSP_K25
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMSA msa{get; init;}
public HL7V24SegmentERR err{get; init;}
public HL7V24SegmentQAK qak{get; init;}
public HL7V24SegmentQPD qpd{get; init;}
public HL7V24SegmentRCP rcp{get; init;}
public HL7V24SegmentDSC dsc{get; init;}


        public string Id { get { return @"RSP_K25"; } }
        public string MessageStructureId { get { return @"RSP_K25"; } }
        public string EventDescription { get { return @"Response - Personnel information"; } }

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

        public HL7V24TriggerEventRSP_K25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.qpd = new HL7V24SegmentQPD(this.message);
this.rcp = new HL7V24SegmentRCP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
