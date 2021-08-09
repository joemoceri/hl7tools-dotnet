using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRSP_K22
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentMSA msa{get; init;}
public HL7V26SegmentERR err{get; init;}
public HL7V26SegmentQAK qak{get; init;}
public HL7V26SegmentQPD qpd{get; init;}
public HL7V26SegmentDSC dsc{get; init;}


        public string Id { get { return @"RSP_K22"; } }
        public string MessageStructureId { get { return @"RSP_K22"; } }
        public string EventDescription { get { return @"Find Candidates Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
"CH_05",

                    };
            }
        }

        public HL7V26TriggerEventRSP_K22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.qpd = new HL7V26SegmentQPD(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
