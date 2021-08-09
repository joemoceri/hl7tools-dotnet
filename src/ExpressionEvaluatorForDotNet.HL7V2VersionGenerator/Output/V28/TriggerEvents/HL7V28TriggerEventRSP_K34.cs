using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRSP_K34
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSTF stf{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentMSA msa{get; init;}
public HL7V28SegmentERR err{get; init;}
public HL7V28SegmentQAK qak{get; init;}
public HL7V28SegmentQPD qpd{get; init;}


        public string Id { get { return @"RSP_K34"; } }
        public string MessageStructureId { get { return @"RSP_K34"; } }
        public string EventDescription { get { return @"Get Donor Record Response"; } }

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

        public HL7V28TriggerEventRSP_K34(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.stf = new HL7V28SegmentSTF(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.qak = new HL7V28SegmentQAK(this.message);
this.qpd = new HL7V28SegmentQPD(this.message);

        }
    }
}
