using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRPL_I02
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentMSA msa{get; init;}
public HL7V26SegmentNTE nte{get; init;}
public HL7V26SegmentDSP dsp{get; init;}
public HL7V26SegmentDSC dsc{get; init;}


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

        public HL7V26TriggerEventRPL_I02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.nte = new HL7V26SegmentNTE(this.message);
this.dsp = new HL7V26SegmentDSP(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
