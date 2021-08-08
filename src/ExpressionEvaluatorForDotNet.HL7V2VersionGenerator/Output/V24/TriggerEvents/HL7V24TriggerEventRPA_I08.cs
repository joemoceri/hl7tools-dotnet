using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventRPA_I08
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMSA msa;
private readonly HL7V24SegmentRF1 rf1;
private readonly HL7V24SegmentPID pid;
private readonly HL7V24SegmentNK1 nk1;
private readonly HL7V24SegmentGT1 gt1;
private readonly HL7V24SegmentACC acc;
private readonly HL7V24SegmentDG1 dg1;
private readonly HL7V24SegmentDRG drg;
private readonly HL7V24SegmentAL1 al1;
private readonly HL7V24SegmentNTE nte;


        public string Id { get { return @"RPA_I08"; } }
        public string MessageStructureId { get { return @"RPA_I08"; } }
        public string EventDescription { get { return @"Request for treatment authorization information acknowledgement"; } }

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

        public HL7V24TriggerEventRPA_I08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.rf1 = new HL7V24SegmentRF1(this.message);
this.pid = new HL7V24SegmentPID(this.message);
this.nk1 = new HL7V24SegmentNK1(this.message);
this.gt1 = new HL7V24SegmentGT1(this.message);
this.acc = new HL7V24SegmentACC(this.message);
this.dg1 = new HL7V24SegmentDG1(this.message);
this.drg = new HL7V24SegmentDRG(this.message);
this.al1 = new HL7V24SegmentAL1(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
