using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventOPL_O37
    {
        public readonly HL7V2Message message;
        public readonly HL7V271SegmentMSH msh;
public readonly HL7V271SegmentSFT sft;
public readonly HL7V271SegmentUAC uac;
public readonly HL7V271SegmentNTE nte;
public readonly HL7V271SegmentPRT prt;


        public string Id { get { return @"OPL_O37"; } }
        public string MessageStructureId { get { return @"OPL_O37"; } }
        public string EventDescription { get { return @"Population/Location-Based Laboratory Order Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            }
        }

        public HL7V271TriggerEventOPL_O37(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.nte = new HL7V271SegmentNTE(this.message);
this.prt = new HL7V271SegmentPRT(this.message);

        }
    }
}
