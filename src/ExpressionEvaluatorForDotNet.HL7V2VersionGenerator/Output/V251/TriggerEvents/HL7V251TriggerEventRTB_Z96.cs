using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRTB_Z96
    {
        public readonly HL7V2Message message;
        public readonly HL7V251SegmentMSH msh;
public readonly HL7V251SegmentSFT sft;
public readonly HL7V251SegmentMSA msa;
public readonly HL7V251SegmentERR err;
public readonly HL7V251SegmentQAK qak;
public readonly HL7V251SegmentQPD qpd;
public readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"RTB_Z96"; } }
        public string MessageStructureId { get { return @"RTB_Z96"; } }
        public string EventDescription { get { return @"Tabular Dispense History Response"; } }

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

        public HL7V251TriggerEventRTB_Z96(HL7V2Message message)
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