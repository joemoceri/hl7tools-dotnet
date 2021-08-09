using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRPI_I01
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentMSA msa{ get; init; }
public HL7V251SegmentPID pid{ get; init; }
public HL7V251SegmentNK1 nk1{ get; init; }
public HL7V251SegmentNTE nte{ get; init; }


        public string Id { get { return @"RPI_I01"; } }
        public string MessageStructureId { get { return @"RPI_I01"; } }
        public string EventDescription { get { return @"Request for insurance information acknowledgement"; } }

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

        public HL7V251TriggerEventRPI_I01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.nk1 = new HL7V251SegmentNK1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
