using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventCCI_I22
    {
        public HL7V2Message message { get; init; }
        public HL7V27SegmentMSH msh{ get; init; }
public HL7V27SegmentSFT sft{ get; init; }
public HL7V27SegmentUAC uac{ get; init; }
public HL7V27SegmentMSA msa{ get; init; }
public HL7V27SegmentERR err{ get; init; }
public HL7V27SegmentPID pid{ get; init; }
public HL7V27SegmentPD1 pd1{ get; init; }
public HL7V27SegmentNK1 nk1{ get; init; }
public HL7V27SegmentREL rel{ get; init; }


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

        public HL7V27TriggerEventCCI_I22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.rel = new HL7V27SegmentREL(this.message);

        }
    }
}
