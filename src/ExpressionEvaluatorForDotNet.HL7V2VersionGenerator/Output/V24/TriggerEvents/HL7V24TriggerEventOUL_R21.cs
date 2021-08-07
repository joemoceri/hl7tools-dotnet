using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventOUL_R21
    {
        public readonly HL7V2Message message;
        public readonly HL7V24SegmentMSH msh;
public readonly HL7V24SegmentNTE nte;
public readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"OUL_R21"; } }
        public string MessageStructureId { get { return @"OUL_R21"; } }
        public string EventDescription { get { return @"Unsolicited laboratory observation"; } }

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

        public HL7V24TriggerEventOUL_R21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.nte = new HL7V24SegmentNTE(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
