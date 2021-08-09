using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRPI_I04
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentMSA msa{ get; init; }
public HL7V28SegmentPID pid{ get; init; }
public HL7V28SegmentNK1 nk1{ get; init; }
public HL7V28SegmentNTE nte{ get; init; }


        public string Id { get { return @"RPI_I04"; } }
        public string MessageStructureId { get { return @"RPI_I04"; } }
        public string EventDescription { get { return @"Return Patient Demographic Data"; } }

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

        public HL7V28TriggerEventRPI_I04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
