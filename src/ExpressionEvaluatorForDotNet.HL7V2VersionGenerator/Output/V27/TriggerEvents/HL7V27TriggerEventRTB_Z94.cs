using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRTB_Z94
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentMSA msa{get; init;}
public HL7V27SegmentERR err{get; init;}
public HL7V27SegmentQAK qak{get; init;}
public HL7V27SegmentQPD qpd{get; init;}
public HL7V27SegmentDSC dsc{get; init;}


        public string Id { get { return @"RTB_Z94"; } }
        public string MessageStructureId { get { return @"RTB_Z94"; } }
        public string EventDescription { get { return @"Tabular Dispense History (Response)"; } }

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

        public HL7V27TriggerEventRTB_Z94(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.qak = new HL7V27SegmentQAK(this.message);
this.qpd = new HL7V27SegmentQPD(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
