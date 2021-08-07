using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventRRI_I15
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentMSA msa;
public readonly HL7V271SegmentRF1 rf1;
public readonly HL7V271SegmentPID pid;
public readonly HL7V271SegmentACC acc;
public readonly HL7V271SegmentDG1 dg1;
public readonly HL7V271SegmentDRG drg;
public readonly HL7V271SegmentAL1 al1;
public readonly HL7V271SegmentNTE nte;


        public string Id { get { return @"RRI_I15"; } }
        public string MessageStructureId { get { return @"RRI_I15"; } }
        public string EventDescription { get { return @"Return Request Patient Referral Status "; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
                    };
            }
        }

        public HL7V271TriggerEventRRI_I15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.rf1 = new HL7V271SegmentRF1(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.acc = new HL7V271SegmentACC(this.message);
this.dg1 = new HL7V271SegmentDG1(this.message);
this.drg = new HL7V271SegmentDRG(this.message);
this.al1 = new HL7V271SegmentAL1(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
