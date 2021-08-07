using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRPL_I02
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentNTE nte;
public readonly HL7V26SegmentDSP dsp;
public readonly HL7V26SegmentDSC dsc;


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
