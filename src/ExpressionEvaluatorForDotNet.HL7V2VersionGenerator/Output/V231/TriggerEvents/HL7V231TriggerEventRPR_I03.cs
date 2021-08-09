using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRPR_I03
    {
        private readonly HL7V2Message message;
        public HL7V231SegmentMSH msh{get; init;}
public HL7V231SegmentMSA msa{get; init;}
public HL7V231SegmentPID pid{get; init;}
public HL7V231SegmentNTE nte{get; init;}


        public string Id { get { return @"RPR_I03"; } }
        public string MessageStructureId { get { return @"RPR_I03"; } }
        public string EventDescription { get { return @"Return patient list"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V231TriggerEventRPR_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
