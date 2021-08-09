using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRRD_O14
    {
        public HL7V2Message message { get; init; }
        public HL7V24SegmentMSH msh{ get; init; }
public HL7V24SegmentMSA msa{ get; init; }
public HL7V24SegmentERR err{ get; init; }
public HL7V24SegmentNTE nte{ get; init; }


        public string Id { get { return @"RRD_O14"; } }
        public string MessageStructureId { get { return @"RRD_O14"; } }
        public string EventDescription { get { return @"Pharmacy/treatment dispense acknowledgement"; } }

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

        public HL7V24TriggerEventRRD_O14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
