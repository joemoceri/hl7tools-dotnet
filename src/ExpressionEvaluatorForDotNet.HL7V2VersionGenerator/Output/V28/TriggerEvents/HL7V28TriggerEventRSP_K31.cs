using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRSP_K31
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentMSA msa{get; init;}
public HL7V28SegmentERR err{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentQAK qak{get; init;}
public HL7V28SegmentQPD qpd{get; init;}
public HL7V28SegmentRCP rcp{get; init;}
public HL7V28SegmentDSC dsc{get; init;}


        public string Id { get { return @"RSP_K31"; } }
        public string MessageStructureId { get { return @"RSP_K31"; } }
        public string EventDescription { get { return @"Dispense History Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V28TriggerEventRSP_K31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.qak = new HL7V28SegmentQAK(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);
this.rcp = new HL7V28SegmentRCP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
