using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRPR_I03
    {
        public HL7V2Message message { get; init; }
        public HL7V25SegmentMSH msh{ get; init; }
public HL7V25SegmentSFT sft{ get; init; }
public HL7V25SegmentMSA msa{ get; init; }
public HL7V25SegmentPID pid{ get; init; }
public HL7V25SegmentNTE nte{ get; init; }


        public string Id { get { return @"RPR_I03"; } }
        public string MessageStructureId { get { return @"RPR_I03"; } }
        public string EventDescription { get { return @"Request/receipt of patient selection list acknowledgement"; } }

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

        public HL7V25TriggerEventRPR_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.nte = new HL7V25SegmentNTE(this.message);

        }
    }
}
