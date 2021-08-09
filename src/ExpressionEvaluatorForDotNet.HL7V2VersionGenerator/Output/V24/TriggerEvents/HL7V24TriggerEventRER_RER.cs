using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRER_RER
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMSA msa{get; init;}
public HL7V24SegmentERR err{get; init;}
public HL7V24SegmentDSC dsc{get; init;}


        public string Id { get { return @"RER_RER"; } }
        public string MessageStructureId { get { return @"RER_RER"; } }
        public string EventDescription { get { return @"Pharmacy/treatment encoded order information response"; } }

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

        public HL7V24TriggerEventRER_RER(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}
