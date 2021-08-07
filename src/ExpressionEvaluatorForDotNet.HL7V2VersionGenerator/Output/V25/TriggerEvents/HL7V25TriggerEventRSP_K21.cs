using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRSP_K21
    {
        public readonly HL7V2Message message;
        public readonly HL7V25SegmentMSH msh;
public readonly HL7V25SegmentSFT sft;
public readonly HL7V25SegmentMSA msa;
public readonly HL7V25SegmentERR err;
public readonly HL7V25SegmentQAK qak;
public readonly HL7V25SegmentQPD qpd;
public readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"RSP_K21"; } }
        public string MessageStructureId { get { return @"RSP_K21"; } }
        public string EventDescription { get { return @"Get Person Demographics Response"; } }

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

        public HL7V25TriggerEventRSP_K21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.qpd = new HL7V25SegmentQPD(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
