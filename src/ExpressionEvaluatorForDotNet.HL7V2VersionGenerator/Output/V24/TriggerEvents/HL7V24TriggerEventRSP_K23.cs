using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRSP_K23
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentMSA msa{ get; init; }
public HL7V24SegmentERR err{ get; init; }
public HL7V24SegmentQAK qak{ get; init; }
public HL7V24SegmentQPD qpd{ get; init; }
public HL7V24SegmentPID pid{ get; init; }
public HL7V24SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RSP_K23"; } }
        public string MessageStructureId { get { return @"RSP_K23"; } }
        public string EventDescription { get { return @"Response - Get corresponding identifiers"; } }

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

        public HL7V24TriggerEventRSP_K23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.qpd = new HL7V24SegmentQPD(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
