using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventORF_R04
    {
        private readonly HL7V2Message message;
        public HL7V22SegmentMSH msh{get; init;}
public HL7V22SegmentMSA msa{get; init;}
public HL7V22SegmentDSC dsc{get; init;}


        public string Id { get { return @"ORF_R04"; } }
        public string MessageStructureId { get { return @"ORF_R04"; } }
        public string EventDescription { get { return @"Response to query; transmission of requested observation"; } }

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

        public HL7V22TriggerEventORF_R04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
