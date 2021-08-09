using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventORU_R30
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentPID pid{get; init;}
public HL7V27SegmentPD1 pd1{get; init;}
public HL7V27SegmentPRT prt{get; init;}
public HL7V27SegmentORC orc{get; init;}
public HL7V27SegmentOBR obr{get; init;}
public HL7V27SegmentNTE nte{get; init;}
public HL7V27SegmentPRT prt{get; init;}


        public string Id { get { return @"ORU_R30"; } }
        public string MessageStructureId { get { return @"ORU_R30"; } }
        public string EventDescription { get { return @"Unsolicited Point-Of-Care Observation Message Without Existing Order - Pla"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V27TriggerEventORU_R30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.prt = new HL7V27SegmentPRT(this.message);
this.orc = new HL7V27SegmentORC(this.message);
this.obr = new HL7V27SegmentOBR(this.message);
this.nte = new HL7V27SegmentNTE(this.message);
this.prt = new HL7V27SegmentPRT(this.message);

        }
    }
}
