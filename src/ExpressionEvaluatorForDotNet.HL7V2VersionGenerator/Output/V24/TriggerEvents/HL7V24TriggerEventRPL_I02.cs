using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRPL_I02
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentMSA msa{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }
public HL7V24SegmentDSP dsp{ get; init; }
public HL7V24SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RPL_I02"; } }
        public string MessageStructureId { get { return @"RPL_I02"; } }
        public string EventDescription { get { return @"Request/receipt of patient selection display list acknowledgement"; } }

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

        public HL7V24TriggerEventRPL_I02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.nte = new HL7V24SegmentNTE(this.message);
this.dsp = new HL7V24SegmentDSP(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
