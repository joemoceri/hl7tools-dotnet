using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRSP_K22
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentMSA msa;
public readonly HL7V271SegmentERR err;
public readonly HL7V271SegmentQAK qak;
public readonly HL7V271SegmentQPD qpd;
public readonly HL7V271SegmentDSC dsc;


        public string Id { get { return @"RSP_K22"; } }
        public string MessageStructureId { get { return @"RSP_K22"; } }
        public string EventDescription { get { return @"Find candidates response"; } }

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

        public HL7V271TriggerEventRSP_K22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.qak = new HL7V271SegmentQAK(this.message);
this.qpd = new HL7V271SegmentQPD(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
