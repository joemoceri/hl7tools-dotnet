using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRPL_I02
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentMSA msa{get; init;}
public HL7V27SegmentNTE nte{get; init;}
public HL7V27SegmentDSP dsp{get; init;}
public HL7V27SegmentDSC dsc{get; init;}


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

        public HL7V27TriggerEventRPL_I02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.nte = new HL7V27SegmentNTE(this.message);
this.dsp = new HL7V27SegmentDSP(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}
