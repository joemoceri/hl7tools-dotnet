using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRCL_I06
    {
        public readonly HL7V2Message message;
        public readonly HL7V23SegmentMSH msh;
public readonly HL7V23SegmentMSA msa;
public readonly HL7V23SegmentQRD qrd;
public readonly HL7V23SegmentQRF qrf;
public readonly HL7V23SegmentPID pid;
public readonly HL7V23SegmentDG1 dg1;
public readonly HL7V23SegmentDRG drg;
public readonly HL7V23SegmentAL1 al1;
public readonly HL7V23SegmentNTE nte;
public readonly HL7V23SegmentDSP dsp;
public readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"RCL_I06"; } }
        public string MessageStructureId { get { return @"RCL_I06"; } }
        public string EventDescription { get { return @"Response of clinical data listing "; } }

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

        public HL7V23TriggerEventRCL_I06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.dg1 = new HL7V23SegmentDG1(this.message);
this.drg = new HL7V23SegmentDRG(this.message);
this.al1 = new HL7V23SegmentAL1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);
this.dsp = new HL7V23SegmentDSP(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}
