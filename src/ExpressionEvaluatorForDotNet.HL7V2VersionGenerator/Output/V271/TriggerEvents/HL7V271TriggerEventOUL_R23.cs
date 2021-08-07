using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventOUL_R23
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentNTE nte;
public readonly HL7V271SegmentNK1 nk1;
public readonly HL7V271SegmentDSC dsc;


        public string Id { get { return @"OUL_R23"; } }
        public string MessageStructureId { get { return @"OUL_R23"; } }
        public string EventDescription { get { return @"Unsolicited Specimen Container Oriented Observation Message"; } }

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

        public HL7V271TriggerEventOUL_R23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.nte = new HL7V271SegmentNTE(this.message);
this.nk1 = new HL7V271SegmentNK1(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}
