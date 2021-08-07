using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventORU_R31
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentPID pid;
public readonly HL7V271SegmentPD1 pd1;
public readonly HL7V271SegmentPRT prt;
public readonly HL7V271SegmentORC orc;
public readonly HL7V271SegmentOBR obr;
public readonly HL7V271SegmentNTE nte;
public readonly HL7V271SegmentPRT prt;


        public string Id { get { return @"ORU_R31"; } }
        public string MessageStructureId { get { return @"ORU_R31"; } }
        public string EventDescription { get { return @"Unsolicited New Point-Of-Care Observation Message - Search For An Order"; } }

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

        public HL7V271TriggerEventORU_R31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.prt = new HL7V271SegmentPRT(this.message);
this.orc = new HL7V271SegmentORC(this.message);
this.obr = new HL7V271SegmentOBR(this.message);
this.nte = new HL7V271SegmentNTE(this.message);
this.prt = new HL7V271SegmentPRT(this.message);

        }
    }
}
