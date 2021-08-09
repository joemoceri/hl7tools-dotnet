using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRPL_I02
    {
        public HL7V2Message message { get; init; }
        public HL7V28SegmentMSH msh{ get; init; }
public HL7V28SegmentSFT sft{ get; init; }
public HL7V28SegmentUAC uac{ get; init; }
public HL7V28SegmentMSA msa{ get; init; }
public HL7V28SegmentNTE nte{ get; init; }
public HL7V28SegmentDSP dsp{ get; init; }
public HL7V28SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RPL_I02"; } }
        public string MessageStructureId { get { return @"RPL_I02"; } }
        public string EventDescription { get { return @"Return Patient Selection Display List"; } }

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

        public HL7V28TriggerEventRPL_I02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.nte = new HL7V28SegmentNTE(this.message);
this.dsp = new HL7V28SegmentDSP(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
