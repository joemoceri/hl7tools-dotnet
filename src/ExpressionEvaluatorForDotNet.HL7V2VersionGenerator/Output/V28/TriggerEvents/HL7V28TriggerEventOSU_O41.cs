using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventOSU_O41
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentMSA msa;
public readonly HL7V28SegmentERR err;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentNTE nte;
public readonly HL7V28SegmentPID pid;
public readonly HL7V28SegmentARV arv;


        public string Id { get { return @"OSU_O41"; } }
        public string MessageStructureId { get { return @"OSU_O41"; } }
        public string EventDescription { get { return @"Order Status Update"; } }

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

        public HL7V28TriggerEventOSU_O41(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.nte = new HL7V28SegmentNTE(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.arv = new HL7V28SegmentARV(this.message);

        }
    }
}
