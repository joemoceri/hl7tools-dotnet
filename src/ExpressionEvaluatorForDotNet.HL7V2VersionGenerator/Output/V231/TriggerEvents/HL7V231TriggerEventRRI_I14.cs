using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRRI_I14
    {
        public readonly HL7V2Message message;
        public readonly HL7V231SegmentMSH msh;
public readonly HL7V231SegmentMSA msa;
public readonly HL7V231SegmentRF1 rf1;
public readonly HL7V231SegmentPID pid;
public readonly HL7V231SegmentACC acc;
public readonly HL7V231SegmentDG1 dg1;
public readonly HL7V231SegmentDRG drg;
public readonly HL7V231SegmentAL1 al1;
public readonly HL7V231SegmentNTE nte;


        public string Id { get { return @"RRI_I14"; } }
        public string MessageStructureId { get { return @"RRI_I14"; } }
        public string EventDescription { get { return @"Return cancel patient referral"; } }

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

        public HL7V231TriggerEventRRI_I14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.rf1 = new HL7V231SegmentRF1(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.acc = new HL7V231SegmentACC(this.message);
this.dg1 = new HL7V231SegmentDG1(this.message);
this.drg = new HL7V231SegmentDRG(this.message);
this.al1 = new HL7V231SegmentAL1(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
