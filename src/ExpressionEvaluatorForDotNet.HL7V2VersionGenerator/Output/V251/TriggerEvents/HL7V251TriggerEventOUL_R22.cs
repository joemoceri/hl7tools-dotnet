using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventOUL_R22
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentNTE nte;
public readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"OUL_R22"; } }
        public string MessageStructureId { get { return @"OUL_R22"; } }
        public string EventDescription { get { return @"Unsolicited Specimen Oriented Observation Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
                    };
            }
        }

        public HL7V251TriggerEventOUL_R22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
