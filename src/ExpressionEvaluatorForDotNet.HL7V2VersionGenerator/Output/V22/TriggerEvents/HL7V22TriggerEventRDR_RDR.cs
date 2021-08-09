using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventRDR_RDR
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentMSA msa{get; init;}
public HL7V22SegmentERR err{get; init;}
public HL7V22SegmentDSC dsc{get; init;}


        public string Id { get { return @"RDR_RDR"; } }
        public string MessageStructureId { get { return @"RDR_RDR"; } }
        public string EventDescription { get { return @"Pharmacy Dispense Information Response"; } }

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

        public HL7V22TriggerEventRDR_RDR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.err = new HL7V22SegmentERR(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
