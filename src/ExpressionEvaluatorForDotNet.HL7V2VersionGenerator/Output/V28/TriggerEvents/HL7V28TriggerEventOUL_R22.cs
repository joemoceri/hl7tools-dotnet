using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventOUL_R22
    {
        public readonly HL7V2Message message;
        public readonly HL7V28SegmentMSH msh;
public readonly HL7V28SegmentSFT sft;
public readonly HL7V28SegmentUAC uac;
public readonly HL7V28SegmentNTE nte;
public readonly HL7V28SegmentNK1 nk1;
public readonly HL7V28SegmentDSC dsc;


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

        public HL7V28TriggerEventOUL_R22(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.nte = new HL7V28SegmentNTE(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.dsc = new HL7V28SegmentDSC(this.message);

        }
    }
}
