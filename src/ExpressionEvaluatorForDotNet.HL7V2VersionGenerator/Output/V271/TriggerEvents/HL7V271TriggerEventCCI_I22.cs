using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventCCI_I22
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentMSA msa;
public readonly HL7V271SegmentERR err;
public readonly HL7V271SegmentPID pid;
public readonly HL7V271SegmentPD1 pd1;
public readonly HL7V271SegmentNK1 nk1;
public readonly HL7V271SegmentREL rel;


        public string Id { get { return @"CCI_I22"; } }
        public string MessageStructureId { get { return @"CCI_I22"; } }
        public string EventDescription { get { return @"Collaborative Care Information"; } }

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

        public HL7V271TriggerEventCCI_I22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.rel = new HL7V271SegmentREL(this.message);

        }
    }
}
