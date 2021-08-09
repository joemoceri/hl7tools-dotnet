using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRTB_Z76
    {
        public HL7V2Message message { get; init; }
        public HL7V251SegmentMSH msh{ get; init; }
public HL7V251SegmentSFT sft{ get; init; }
public HL7V251SegmentMSA msa{ get; init; }
public HL7V251SegmentERR err{ get; init; }
public HL7V251SegmentQAK qak{ get; init; }
public HL7V251SegmentQPD qpd{ get; init; }
public HL7V251SegmentDSC dsc{ get; init; }


        public string Id { get { return @"RTB_Z76"; } }
        public string MessageStructureId { get { return @"RTB_Z76"; } }
        public string EventDescription { get { return @"Tabular Patient List"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V251TriggerEventRTB_Z76(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.qak = new HL7V251SegmentQAK(this.message);
this.qpd = new HL7V251SegmentQPD(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
