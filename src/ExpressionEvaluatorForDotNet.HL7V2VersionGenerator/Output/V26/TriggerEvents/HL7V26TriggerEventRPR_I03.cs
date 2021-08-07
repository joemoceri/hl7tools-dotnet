using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventRPR_I03
    {
        public readonly HL7V2Message message;
        public readonly HL7V26SegmentMSH msh;
public readonly HL7V26SegmentSFT sft;
public readonly HL7V26SegmentUAC uac;
public readonly HL7V26SegmentMSA msa;
public readonly HL7V26SegmentPID pid;
public readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"RPR_I03"; } }
        public string MessageStructureId { get { return @"RPR_I03"; } }
        public string EventDescription { get { return @"Return Patient Selection List"; } }

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

        public HL7V26TriggerEventRPR_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
